using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Scottxu.WebServiceDataProvider
{
    /// <summary>
    /// 使用C#代码的WebService数据源提供程序的查询类
    /// </summary>
    public class CSharpCodeCommand : CommandBase
    {
        //WebServiceObject对象
        private object WebServiceQueryObject;

        //方法信息
        private MethodInfo MethodInfo;

        //源代码
        private string _QueryCode;

        public string QueryCode
        {
            get
            {
                return _QueryCode;
            }
        }

        /// <summary>
        /// 获取或设置此查询所使用的参数
        /// </summary>
        public Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// 初始化一个使用C#代码的WebService数据源提供程序的查询类的实例
        /// </summary>
        /// <param name="method"></param>
        /// <param name="connection"></param>
        public CSharpCodeCommand(string queryCode, Connection connection) : base(connection)
        {
            _QueryCode = queryCode;

            CodeDomProvider codeDomProvider = CodeDomProvider.CreateProvider("CSharp");

            //生成WebService源代码
            MemoryStream memoryStream = new MemoryStream();
            StreamWriter streamWriter = new StreamWriter(memoryStream, new UTF8Encoding());
            codeDomProvider.GenerateCodeFromCompileUnit(CodeCompileUnit, streamWriter, new CodeGeneratorOptions());
            streamWriter.Flush();
            memoryStream.Position = 0;
            string webServiceCode = new StreamReader(memoryStream, new UTF8Encoding()).ReadToEnd();
            streamWriter.Close();
            memoryStream.Close();

            //添加模板代码
            string _queryCode
                = "using System;"
                + "using System.Collections.Generic;"
                + "using System.Linq;"
                + "using System.Text;"
                + "using System.Threading.Tasks;"
                + "public class WebServiceQuery{"
                    + "public object Main(Dictionary<string, object> parameters) {"
                        + $"\n{queryCode}\n"
                    + "}"
                + "}";

            codeDomProvider = CodeDomProvider.CreateProvider("CSharp");

            CompilerParameters compilerParameters = new CompilerParameters
            {
                GenerateExecutable = false,
                GenerateInMemory = true,
                ReferencedAssemblies =
                {
                    "System.dll",
                    "System.Core.dll",
                    "System.Data.dll",
                    "System.Data.DataSetExtensions.dll",
                    "System.Deployment.dll",
                    "System.Drawing.dll",
                    "System.Net.Http.dll",
                    "System.Xml.dll",
                    "System.Xml.Linq.dll",
                    "System.Web.Services.dll",
                    "System.Data.dll",
                    "Newtonsoft.Json.dll"
                }
            };

            CompilerResults CompilerResults = codeDomProvider.CompileAssemblyFromSource(compilerParameters, webServiceCode, _queryCode);

            //使用Reflection调用WebService
            Assembly assembly = CompilerResults.CompiledAssembly;
            Type type = assembly.GetType("WebServiceQuery"); // 如果在前面为代理类添加了命名空间，此处需要将命名空间添加到类型前面。

            WebServiceQueryObject = Activator.CreateInstance(type);
            MethodInfo = type.GetMethod("Main");
            Parameters = new Dictionary<string, object>();
        }

        /// <summary>
        /// 从远处服务器查询数据
        /// </summary>
        /// <returns>查询结果对象</returns>
        override public Object Query()
        {
            return MethodInfo.Invoke(WebServiceQueryObject, new object[] { Parameters });
        }
    }
}
