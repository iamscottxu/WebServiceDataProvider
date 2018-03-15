# WebServiceDataProvider
WebServiceDataProvider是一个用于动态调用WebService的C#类库，这个类库非常灵活，不经可以仅通过两三条语句来调用WebService提供的方法，还可以使用动态编译的代码来调用这些方法。你无需在编译前添加好WebService的引用，只用添加这个类库，你就可以在需要时轻松使用WebService提供的服务。

## 依赖
* Newtonsoft.json (这个库已经添加到Nuget中)

## 快速开始
在你的项目中搜索并添加名为“Scottxu.WebServiceDataProvider”的NuGet程序包，即可使用。

## 如何使用
只需简单的几行代码，就可以调用任何WebService。

>### 使用方法名调用
```C#
using Scottxu.WebServiceDataProvider;
var connection = new Connection("http://xxxx/xxxx.asmx");
var command = connection.GetMethodCommand("WebService方法名", "WebService名称");
string returnString = connection.Query();
```

>### 使用动态编译的C#代码调用
```C#
using Scottxu.WebServiceDataProvider;
var connection = new Connection("http://xxxx/xxxx.asmx");
var command = connection.GetCSharpCommand(
  "var webService = new WebService名称();" +
  "return webService.WebService方法名();" +
  );
string returnString = connection.Query();
```
## 联系作者
如果有任何问题请写Issus。<br/>
Email：xyc0714@aliyun.com
