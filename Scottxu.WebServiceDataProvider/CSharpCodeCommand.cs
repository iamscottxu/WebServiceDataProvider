using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Microsoft.CSharp.RuntimeBinder;

namespace Scottxu.WebServiceDataProvider
{
    /// <summary>
    /// 使用C#代码的WebService数据源提供程序的查询类
    /// </summary>
    public class CSharpCodeCommand : CommandBase
    {
        //WebServiceObject对象
        private readonly object _webServiceQueryObject;

        //方法信息
        private readonly MethodInfo _methodInfo;

        /// <summary>
        /// 获取查询所用的代码
        /// </summary>
        public string QueryCode { get; }

        /// <summary>
        /// 获取或设置此查询所使用的参数
        /// </summary>
        public Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// 初始化一个使用C#代码的WebService数据源提供程序的查询类的实例
        /// </summary>
        /// <param name="queryCode">查询所用的代码</param>
        /// <param name="connection">WebService数据源提供程序的连接类的实例</param>
        public CSharpCodeCommand(string queryCode, Connection connection) : base(connection)
        {
            QueryCode = queryCode;

            var codeDomProvider = CodeDomProvider.CreateProvider("CSharp");

            //生成WebService源代码
            var memoryStream = new MemoryStream();
            var streamWriter = new StreamWriter(memoryStream, new UTF8Encoding());
            codeDomProvider.GenerateCodeFromCompileUnit(CodeCompileUnit, streamWriter, new CodeGeneratorOptions());
            streamWriter.Flush();
            memoryStream.Position = 0;
            var webServiceCode = new StreamReader(memoryStream, new UTF8Encoding()).ReadToEnd();
            streamWriter.Close();
            memoryStream.Close();

            //添加模板代码
            var _queryCode
                = "using System;"
                + "using System.Data;"
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

            var compilerParameters = new CompilerParameters
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
                    "System.Data.dll"
                }
            };

            var compilerResults = codeDomProvider.CompileAssemblyFromSource(compilerParameters, webServiceCode, _queryCode);

            //包含错误，编译失败
            if (compilerResults.Errors.HasErrors)
            {
                var compilerErrors = compilerResults.Errors;
                var errorString = Properties.Resources.CompilerErrorText;
                foreach (CompilerError compilerError in compilerErrors)
                {
                    compilerError.Line--;
                    compilerError.FileName = string.Empty;
                    errorString +=
                        $"\n({compilerError.Line},{compilerError.Column}){compilerError.ErrorNumber} " +
                        $"{(compilerError.IsWarning ? Properties.Resources.WarningText : Properties.Resources.ErrorText)} {compilerError.ErrorText} ";
                }
                throw new CompilerException(errorString, compilerErrors); //引发异常
            }

            //使用Reflection调用WebService
            var assembly = compilerResults.CompiledAssembly;
            var type = assembly.GetType("WebServiceQuery"); // 如果在前面为代理类添加了命名空间，此处需要将命名空间添加到类型前面。

            _webServiceQueryObject = Activator.CreateInstance(type);
            _methodInfo = type.GetMethod("Main");
            Parameters = new Dictionary<string, object>();
        }

        /// <summary>
        /// 从远处服务器查询数据
        /// </summary>
        /// <returns>查询结果对象</returns>
        public override object Query()
        {
            return _methodInfo.Invoke(_webServiceQueryObject, new object[] { Parameters });
        }
    }
}
