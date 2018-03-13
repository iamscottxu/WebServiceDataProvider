using System;
using System.CodeDom;
using System.Web.Services.Description;
using System.Xml.Serialization;

namespace Scottxu.WebServiceDataProvider
{
    /// <summary>
    /// WebService数据源提供程序的查询抽象基类
    /// </summary>
    public abstract class CommandBase
    {
        //WebService客户端CodeDOM程序图容器
        protected CodeCompileUnit CodeCompileUnit;

        //WebService数据源提供程序的连接实例
        private Connection _Connection;

        //执行查询
        abstract public Object Query();

        /// <summary>
        /// 获取此查询基类所使用的WebService数据源提供程序的连接
        /// </summary>
        public Connection Connection
        {
            get
            {
                return _Connection;
            }
        }

        //使用CodeDom编译客户端代理类
        protected CommandBase(Connection connection)
        {
            _Connection = connection;

            //如果还没有获取服务说明则先获取服务说明
            if (connection.ServiceDescription == null) connection.LoadServiceDescription();

            //创建客户端代理类
            ServiceDescriptionImporter ServiceDescriptionImporter = new ServiceDescriptionImporter
            {
                ProtocolName = "Soap", // 指定访问协议。
                Style = ServiceDescriptionImportStyle.Client, // 生成客户端代理
                CodeGenerationOptions = CodeGenerationOptions.GenerateProperties  //| CodeGenerationOptions.GenerateNewAsync
            };

            ServiceDescriptionImporter.AddServiceDescription(connection.ServiceDescription, null, null); // 添加 WSDL 文档

            //使用CodeDom编译客户端代理类
            CodeNamespace codeNamespace = new CodeNamespace(); // 为代理类添加命名空间，缺省为全局空间
            CodeCompileUnit = new CodeCompileUnit();
            CodeCompileUnit.Namespaces.Add(codeNamespace);
            ServiceDescriptionImporter.Import(codeNamespace, CodeCompileUnit);
        }
    }
}
