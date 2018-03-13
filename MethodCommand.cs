using System;
using System.CodeDom.Compiler;
using System.Reflection;

namespace Scottxu.WebServiceDataProvider
{
    /// <summary>
    /// 使用方法的WebService数据源提供程序的查询类
    /// </summary>
    public class MethodCommand : CommandBase
    {
        //方法信息
        private MethodInfo MethodInfo;

        //WebServiceObject对象
        private object WebServiceObject;

        /// <summary>
        /// 获取或设置此查询所使用的参数
        /// </summary>
        public object[] Parameters { get; set; }

        /// <summary>
        /// 获取此查询实例所使用的方法
        /// </summary>
        public string Method
        {
            get
            {
                return MethodInfo.Name;
            }
        }

        /// <summary>
        /// 获取此查询实例所使用的方法
        /// </summary>
        public string Class
        {
            get
            {
                return WebServiceObject.GetType().Name;
            }
        }

        /// <summary>
        /// 初始化一个使用方法的WebService数据源提供程序的查询类的实例
        /// </summary>
        /// <param name="method"></param>
        /// <param name="connection"></param>
        public MethodCommand(string method, string _class, Connection connection) : base(connection)
        {
            CodeDomProvider codeDomProvider = CodeDomProvider.CreateProvider("CSharp");

            CompilerParameters compilerParameters = new CompilerParameters
            {
                GenerateExecutable = false,
                GenerateInMemory = true,
                ReferencedAssemblies =
                {
                    "System.dll",
                    "System.Xml.dll",
                    "System.Web.Services.dll",
                    "System.Data.dll"
                }
            };

            CompilerResults compilerResults = codeDomProvider.CompileAssemblyFromDom(compilerParameters, CodeCompileUnit);

            //使用Reflection调用WebService
            Assembly assembly = compilerResults.CompiledAssembly;
            Type type = assembly.GetType(_class); // 如果在前面为代理类添加了命名空间，此处需要将命名空间添加到类型前面。

            WebServiceObject = Activator.CreateInstance(type);
            MethodInfo = type.GetMethod(method);
        }

        /// <summary>
        /// 从远处服务器查询数据
        /// </summary>
        /// <returns>查询结果对象</returns>
        override public Object Query()
        {
            return MethodInfo.Invoke(WebServiceObject, Parameters);
        }
    }
}
