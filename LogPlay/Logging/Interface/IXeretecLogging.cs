using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LogPlay.Logging.Interface
{
    public interface IXeretecLogging
    {
        void Entering([CallerMemberName] string memberName = "");
        void Fatal(string loggingMessage, [CallerMemberName] string memberName = "");
        void Error(string loggingMessage, [CallerMemberName] string memberName = "");
        void Warn(string loggingMessage, [CallerMemberName] string memberName = "");
        void Info(string loggingMessage, [CallerMemberName] string memberName = "");
        void Debug(string loggingMessage, [CallerMemberName] string memberName = "");
        void Trace(string loggingMessage, [CallerMemberName] string memberName = "");
    }
}
