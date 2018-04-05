using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Scottxu.WebServiceDataProvider
{
    /// <summary>
    /// 使用方法的WebService数据源提供程序的查询类
    /// </summary>
    public class MethodCommand : CommandBase
    {
        //方法信息
        private readonly MethodInfo _methodInfo;

        //WebServiceObject对象
        private readonly object _webServiceObject;

        //参数列表
        private readonly SortedDictionary<string, string> _parameters;

        //参数值列表
        private readonly object[] _parameterValues;

        /// <summary>
        /// 获取或设置此查询所使用的参数
        /// </summary>
        public object this[string parameterName]
        {
            get => this[_parameters.Keys.ToList().FindIndex(p => p == parameterName)];
            set => this[_parameters.Keys.ToList().FindIndex(p => p == parameterName)] = value;
        }

        /// <summary>
        /// 获取或设置此查询所使用的参数
        /// </summary>
        public object this[int index]
        {
            get => _parameterValues[index];
            set
            {

                if (value.GetType() != _methodInfo.GetParameters()[index].ParameterType)
                    throw new ArgumentException(
                        string.Format(Properties.Resources.ArgumentExceptionArgumentTypeErrorText,
                            _parameters.Keys.ToList()[index],
                            _methodInfo.GetParameters()[index].ParameterType,
                            value.GetType())
                        );
                _parameterValues[index] = value;
            }
        }

        /// <summary>
        /// 获取此查询实例所使用的方法
        /// </summary>
        public string Method => _methodInfo.Name;

        /// <summary>
        /// 获取此查询实例所使用的方法
        /// </summary>
        public string Class => _webServiceObject.GetType().Name;

        /// <summary>
        /// 初始化一个使用方法的WebService数据源提供程序的查询类的实例
        /// </summary>
        /// <param name="method"></param>
        /// <param name="_class"></param>
        /// <param name="connection"></param>
        public MethodCommand(string method, string _class, Connection connection) : base(connection)
        {
            var codeDomProvider = CodeDomProvider.CreateProvider("CSharp");

            var compilerParameters = new CompilerParameters
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

            var compilerResults = codeDomProvider.CompileAssemblyFromDom(compilerParameters, CodeCompileUnit);

            //使用Reflection调用WebService
            var assembly = compilerResults.CompiledAssembly;
            var type = assembly.GetType(_class); // 如果在前面为代理类添加了命名空间，此处需要将命名空间添加到类型前面。

            _webServiceObject = Activator.CreateInstance(type);
            _methodInfo = type.GetMethod(method);

            //获取参数列表
            _parameters = Connection.GetMethodParameterList(_class, method);
            _parameterValues = new object[_parameters.Count];
        }

        /// <summary>
        /// 从远处服务器查询数据
        /// </summary>
        /// <returns>查询结果对象</returns>
        public override object Query()
        {
            return _methodInfo.Invoke(_webServiceObject, _parameterValues);
        }
    }
}
