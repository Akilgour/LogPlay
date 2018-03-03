using LogPlay.Logging.Interface;
using Microsoft.Owin.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.CompilerServices;

namespace LogPlay.Logging
{
    public class XeretecLogging : IXeretecLogging
    {
        private readonly NLog.ILogger _logger;

        public XeretecLogging()
        {
            _logger = LogManager.GetCurrentClassLogger();
        }

        public void Debug(string loggingMessage, [CallerMemberName] string memberName = "")
        {
            System.Diagnostics.Trace.WriteLine($"Debug Message from {memberName}");
        }

        public void Error(string loggingMessage, [CallerMemberName] string memberName = "")
        {
            System.Diagnostics.Trace.WriteLine($"Error Message from {memberName}");
        }

        public void Fatal(string loggingMessage, [CallerMemberName] string memberName = "")
        {
            System.Diagnostics.Trace.WriteLine($"Fatal Message from {memberName}");
        }

        public void Info(string loggingMessage, [CallerMemberName] string memberName = "")
        {
            System.Diagnostics.Trace.WriteLine($"Info Message from {memberName}");
        }

        public void Trace(string loggingMessage, [CallerMemberName] string memberName = "")
        {
            System.Diagnostics.Trace.WriteLine($"Trace Message from {memberName}");
        }

        public void Warn(string loggingMessage, [CallerMemberName] string memberName = "")
        {
            System.Diagnostics.Trace.WriteLine($"Warn Message from {memberName}");
        }
    }
}