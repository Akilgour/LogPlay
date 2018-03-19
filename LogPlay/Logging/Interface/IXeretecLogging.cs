using System;
using System.Runtime.CompilerServices;

namespace LogPlay.Logging.Interface
{
    public interface IXeretecLogging
    {
        void Entering([CallerMemberName] string memberName = "");

        void Exiting(object result, [CallerMemberName] string memberName = "");

        void Fatal(string loggingMessage, [CallerMemberName] string memberName = "");

        void Error(string loggingMessage, [CallerMemberName] string memberName = "");

        void Error(string loggingMessage, Exception exception,  [CallerMemberName] string memberName = "");

        void Warn(string loggingMessage, [CallerMemberName] string memberName = "");

        void Info(string loggingMessage, [CallerMemberName] string memberName = "");

        void Debug(string loggingMessage, [CallerMemberName] string memberName = "");
   
        void Trace(string loggingMessage, [CallerMemberName] string memberName = "");
    }
}