项目地址：https://github.com/iamscottxu/WebServiceDataProvider
自述文件：https://github.com/iamscottxu/WebServiceDataProvider/blob/master/README.md
许可协议：https://github.com/iamscottxu/WebServiceDataProvider/blob/master/LICENSE

WebServiceDataProvider是一个用于动态调用WebService的C#类库，使用此类库，不仅可以仅通
过两三条语句来调用WebService提供的方法，还可以使用动态编译的代码来调用这些方法。你无
需在编译前添加好WebService的引用，只用添加这个类库，你就可以在需要时轻松使用
WebService提供的服务。


依赖
	Newtonsoft.json >= 11.0.2


快速开始
	在你的项目中搜索并添加名为“Scottxu.WebServiceDataProvider”的NuGet程序包，即可使用。


如何使用
	只需简单的几行代码，就可以调用任何WebService。

	使用方法名调用
		using Scottxu.WebServiceDataProvider;
		var connection = new Connection("http://xxxx/xxxx.asmx");
		var command = connection.GetMethodCommand("WebService方法名", "WebService名称");
		string returnString = connection.Query();

	使用动态编译的C#代码调用
		using Scottxu.WebServiceDataProvider;
		var connection = new Connection("http://xxxx/xxxx.asmx");
		var command = connection.GetCSharpCommand(
			"var webService = new WebService名称();" +
			"return webService.WebService方法名();" +
		);
		string returnString = connection.Query();


联系作者
	如果有任何问题请写Issus。
	Email：xyc0714@aliyun.com

许可协议
MIT License

Copyright (c) 2018 Scott Xu <xyc0714@aliyun.com>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.