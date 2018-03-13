using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web.Services.Description;

namespace Scottxu.WebServiceDataProvider
{
    /// <summary>
    /// 表示一个WebService数据源提供程序的连接类
    /// </summary>
    public class Connection
    {
        /// <summary>
        /// 获取或设置WebService的地址
        /// </summary>
        public string URL { get; set; }

        /// <summary>
        /// 获取或设置用于登录WebService所在站点的用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 获取或设置用于登录WebService所在站点的密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 获取或设置用于登录WebService所在站点的域
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// 获取或设置一个值，该值表示此站点是否使用默认身份认证
        /// </summary>
        public bool UseDefaultCredentials { get; set; }

        /// <summary>
        /// 获取或设置连接到该WebService所使用的连接字符串
        /// </summary>
        public string ConnectionString
        {
            get
            {
                object returnObject;
                if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password))
                {
                    returnObject = new { URL, UseDefaultCredentials };
                }
                else if (string.IsNullOrEmpty(Domain))
                {
                    returnObject = new { URL, UserName, Password, UseDefaultCredentials };
                }
                else
                {
                    returnObject = new { URL, UserName, Password, Domain, UseDefaultCredentials };
                }
                return JsonConvert.SerializeObject(returnObject);
            }
            set
            {
                JObject jObject = JsonConvert.DeserializeObject<JObject>(value);
                URL = UserName = Password = Domain = null;
                UseDefaultCredentials = true;
                foreach (JProperty jProperty in jObject.Properties())
                {
                    switch (jProperty.Name)
                    {
                        case "URL":
                            URL = jProperty.Value.Value<string>();
                            break;
                        case "UserName":
                            UserName = jProperty.Value.Value<string>();
                            break;
                        case "Password":
                            Password = jProperty.Value.Value<string>();
                            break;
                        case "Domain":
                            Domain = jProperty.Value.Value<string>();
                            break;
                        case "UseDefaultCredentials":
                            UseDefaultCredentials = jProperty.Value.Value<bool>();
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// 获取WebService的服务说明
        /// </summary>
        public ServiceDescription ServiceDescription{ private set; get; }

        /// <summary>
        /// 初始化一个WebService数据源提供程序的连接类的实例
        /// </summary>
        /// <param name="url">WebService的地址</param>
        /// <param name="UseDefaultCredentials">此站点是否使用默认身份认证</param>
        public Connection(string url, bool useDefaultCredentials)
        {
            URL = url;
            UseDefaultCredentials = useDefaultCredentials;
        }

        /// <summary>
        /// 初始化一个WebService数据源提供程序的连接类的实例
        /// </summary>
        /// <param name="url">WebService的地址</param>
        /// <param name="userName">用于登录WebService所在站点的用户名</param>
        /// <param name="password">用于登录WebService所在站点的密码</param>
        public Connection(string url, string userName, string password) : this(url, false)
        {
            UserName = userName;
            Password = password;
        }

        /// <summary>
        /// 初始化一个WebService数据源提供程序的连接对象
        /// </summary>
        /// <param name="url">WebService的地址</param>
        /// <param name="userName">用于登录WebService所在站点的用户名</param>
        /// <param name="password">用于登录WebService所在站点的密码</param>
        /// <param name="domain">用于登录WebService所在站点的域</param>
        public Connection(string url, string userName, string password, string domain) : this(url, userName, password)
        {
            Domain = domain;
        }

        /// <summary>
        /// 初始化一个WebService数据源提供程序的连接对象
        /// </summary>
        /// <param name="connectionString">连接到该WebService所使用的连接字符串</param>
        public Connection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        /// <summary>
        /// 从服务器加载WebService的服务说明
        /// </summary>
        public ServiceDescription LoadServiceDescription()
        {
            //下载WSDL信息
            WebClient webClient = new WebClient
            {
                UseDefaultCredentials = UseDefaultCredentials
            };
            if (!UseDefaultCredentials)
            {
                if (string.IsNullOrEmpty(UserName) && string.IsNullOrEmpty(Password)
                    && string.IsNullOrEmpty(Domain))
                    webClient.Credentials = new NetworkCredential(UserName, Password, Domain);
                else if (string.IsNullOrEmpty(UserName) && string.IsNullOrEmpty(Password)) {
                    int domainIndex = UserName.LastIndexOf('@');
                    if (domainIndex > 0 && domainIndex < UserName.Length - 1)
                    {
                        string userName = UserName.Remove(domainIndex);
                        string domain = UserName.Remove(0, domainIndex + 1);
                        webClient.Credentials = new NetworkCredential(userName, Password, domain);
                    }
                    else
                    {
                        webClient.Credentials = new NetworkCredential(UserName, Password);
                    }
                }
            }
            else webClient.Credentials = new NetworkCredential();
            Stream stream = webClient.OpenRead($"{URL}?WSDL");

            //创建和格式化WSDL文档
            ServiceDescription = ServiceDescription.Read(stream);
            return ServiceDescription;
        }

        /// <summary>
        /// 获取一个列表，该列表包含了此WebService的类
        /// </summary>
        /// <returns>类列表</returns>
        public List<string> GetClassList()
        {
            //如果还没有获取服务说明则先获取服务说明
            if (ServiceDescription == null) LoadServiceDescription();
            List<string> classList = new List<string>();
            foreach (Service service in ServiceDescription.Services)
            {
                classList.Add(service.Name);
            };
            return classList;
        }

        /// <summary>
        /// 获取一个列表，该列表包含了此WebService的类中的方法
        /// </summary>
        /// <param name="_class">类名</param>
        /// <returns>方法列表</returns>
        public List<string> GetMethodList(string _class)
        {
            //如果还没有获取服务说明则先获取服务说明
            if (ServiceDescription == null) LoadServiceDescription();
            List<string> methodList = new List<string>();
            foreach (Operation operation in ServiceDescription.PortTypes[$"{_class}Soap"].Operations)
            {
                methodList.Add(operation.Name);
            };
            return methodList;
        }

        /// <summary>
        /// 获取指定方法的描述
        /// </summary>
        /// <param name="_class">类名</param>
        /// <param name="method">方法名</param>
        /// <returns>指定方法的描述</returns>
        public string GetMethodDescription(string _class, string method)
        {
            //如果还没有获取服务说明则先获取服务说明
            if (ServiceDescription == null) LoadServiceDescription();
            List<string> methodList = new List<string>();
            foreach (Operation operation in ServiceDescription.PortTypes[$"{_class}Soap"].Operations)
            {
                if (operation.Name == method)
                {
                    return operation.Documentation;
                }
            };
            throw new KeyNotFoundException("指定的方法不存在。");
        }

        /// <summary>
        /// 获取指定方法的参数列表
        /// </summary>
        /// <param name="_class">类名</param>
        /// <param name="method">方法名</param>
        /// <returns>指定方法的描述</returns>
        public Dictionary<string, string> GetMethodParameterList(string _class, string method)
        {
            //如果还没有获取服务说明则先获取服务说明
            if (ServiceDescription == null) LoadServiceDescription();
            List<string> methodList = new List<string>();
            foreach (Operation operation in ServiceDescription.PortTypes[$"{_class}Soap"].Operations)
            {
                if (operation.Name == method)
                {
                    string messageName = operation.Messages.Input.Message.Name;
                    var messageElement = ServiceDescription.Messages[messageName].Parts["parameters"].Element;
                    var schemaElement = (System.Xml.Schema.XmlSchemaElement)ServiceDescription.Types.Schemas[messageElement.Namespace].Elements[messageElement];
                    var particle = ((System.Xml.Schema.XmlSchemaComplexType)schemaElement.SchemaType).Particle;
                    if (particle == null) return new Dictionary<string, string>();
                    var parameterObjectConnection = ((System.Xml.Schema.XmlSchemaSequence)particle).Items;
                    var parameters = new Dictionary<string, string>();
                    foreach (var parameterObject in parameterObjectConnection)
                    {
                        var parameterSchemaElement = (System.Xml.Schema.XmlSchemaElement)parameterObject;
                        var parameter = new Dictionary<string, string>();
                        parameters.Add(parameterSchemaElement.Name, parameterSchemaElement.SchemaTypeName.Name);
                    }
                    return parameters;
                }
            };
            throw new KeyNotFoundException("指定的方法不存在。");
        }

        /// <summary>
        /// 获取指定方法的返回类型
        /// </summary>
        /// <param name="_class">类名</param>
        /// <param name="method">方法名</param>
        /// <returns>指定方法的描述</returns>
        public string GetMethodReturnType(string _class, string method)
        {
            //如果还没有获取服务说明则先获取服务说明
            if (ServiceDescription == null) LoadServiceDescription();
            List<string> methodList = new List<string>();
            foreach (Operation operation in ServiceDescription.PortTypes[$"{_class}Soap"].Operations)
            {
                if (operation.Name == method)
                {
                    string messageName = operation.Messages.Output.Message.Name;
                    var messageElement = ServiceDescription.Messages[messageName].Parts["parameters"].Element;
                    var schemaElement = (System.Xml.Schema.XmlSchemaElement)ServiceDescription.Types.Schemas[messageElement.Namespace].Elements[messageElement];
                    var particle = ((System.Xml.Schema.XmlSchemaComplexType)schemaElement.SchemaType).Particle;
                    var parameterObjectConnection = ((System.Xml.Schema.XmlSchemaSequence)particle).Items;
                    var parameterSchemaElement = (System.Xml.Schema.XmlSchemaElement)parameterObjectConnection[0];
                    return parameterSchemaElement.SchemaTypeName.Name;
                }
            };
            throw new KeyNotFoundException("指定的方法不存在。");
        }

        /// <summary>
        /// 获取类似文档的方法说明
        /// </summary>
        /// <param name="_class">类名</param>
        /// <param name="method">方法名</param>
        /// <returns></returns>
        public string GetMethodDoc(string _class, string method)
        {
            string parameterListText = string.Empty;
            foreach (var ParameterList in GetMethodParameterList(_class, method))
            {
                parameterListText += $"{ParameterList.Value} {ParameterList.Key}, ";
            }
            if (!string.IsNullOrEmpty(parameterListText)) parameterListText = parameterListText.Remove(parameterListText.Length - 2);
            string returnText = $"{method}方法\n\n"
                + $"{GetMethodDescription(_class, method)}\n\n"
                + $"类：{_class}"
                + $"    {GetClassDescription(_class)}\n\n"
                + "语法：\n"
                + $"  public {GetMethodReturnType(_class, method)} {method}({parameterListText})";
            return returnText;
        }

        /// <summary>
        /// 获取指定类的描述
        /// </summary>
        /// <param name="_class">类名</param>
        /// <returns>指定类的描述</returns>
        public string GetClassDescription(string _class)
        {
            //如果还没有获取服务说明则先获取服务说明
            if (ServiceDescription == null) LoadServiceDescription();
            return ServiceDescription.Services[_class].Documentation;
        }

        /// <summary>
        /// 获取一个WebService查询对象
        /// </summary>
        /// <param name="queryCode">查询代码</param>
        /// <returns>WebService查询对象</returns>
        public CSharpCodeCommand GetCSharpCommand(string queryCode)
        {
            return new CSharpCodeCommand(queryCode, this);
        }

        /// <summary>
        /// 获取一个WebService查询对象
        /// </summary>
        /// <param name="method">要执行的方法</param>
        /// <returns>WebService查询对象</returns>
        public MethodCommand GetMethodCommand(string method, string _class)
        {
            return new MethodCommand(method, _class, this);
        }
    }
}
