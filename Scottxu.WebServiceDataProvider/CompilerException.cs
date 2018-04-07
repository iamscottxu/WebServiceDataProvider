using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Scottxu.WebServiceDataProvider
{
    /// <summary>
    /// 表示在编译时发生错误
    /// </summary>
    public class CompilerException : Exception
    {
        private CompilerException(){}
        private CompilerException(SerializationInfo info, StreamingContext context):base(info, context) {}
        private CompilerException(string message, Exception innerException) : base(message, innerException) {}
        private CompilerException(string message) : base(message) { }

        internal CompilerException(string message, CompilerErrorCollection compilerErrors) : base(message)
        {
            CompilerErrors = compilerErrors;
        }
        /// <summary>
        /// 编译错误或警告的集合
        /// </summary>
        public CompilerErrorCollection CompilerErrors { get; }
    }
}
