﻿using LogPlay.Logging.Interface;
using Microsoft.Owin.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.CompilerServices;
using LogPlay.Helpers;

namespace LogPlay.Logging
{
    public class XeretecLogging : IXeretecLogging
    {
        private readonly NLog.ILogger _logger;

        public XeretecLogging()
        {
            _logger = LogManager.GetCurrentClassLogger();
        }

        public void Entering([CallerMemberName] string memberName = "")
        {
            System.Diagnostics.Trace.WriteLine($"Entering method {memberName}");
            _logger.Trace($"Entering method {memberName}");
        }

        public void Exiting(object result, [CallerMemberName] string memberName = "")
        {
            var resultAsXML = StringWriterHelper.Resolve(result);
            System.Diagnostics.Trace.WriteLine($"Exiting method {memberName} Result {resultAsXML}");
            _logger.Trace($"Exiting method {memberName} Result {resultAsXML}");
        }
        public void Debug(string loggingMessage, [CallerMemberName] string memberName = "")
        {
            System.Diagnostics.Trace.WriteLine($"Debug Message from {memberName}");
            _logger.Debug(loggingMessage);
        }

        public void Error(string loggingMessage, [CallerMemberName] string memberName = "")
        {
            System.Diagnostics.Trace.WriteLine($"Error Message from {memberName}");
            _logger.Error(loggingMessage);
        }

        public void Error(string loggingMessage, Exception exception, [CallerMemberName] string memberName = "")
        {
            var msg = $"Error Message from {memberName} Exception {exception} ";
            System.Diagnostics.Trace.WriteLine(msg);
            _logger.Error(exception, msg);
        }

        public void Fatal(string loggingMessage, [CallerMemberName] string memberName = "")
        {
            System.Diagnostics.Trace.WriteLine($"Fatal Message from {memberName}");
            _logger.Fatal(loggingMessage);
        }

        public void Info(string loggingMessage, [CallerMemberName] string memberName = "")
        {
            System.Diagnostics.Trace.WriteLine($"Info Message from {memberName}");
            _logger.Info(loggingMessage);
        }

        public void Trace(string loggingMessage, [CallerMemberName] string memberName = "")
        {
            System.Diagnostics.Trace.WriteLine($"Trace Message from {memberName}");
            _logger.Trace(loggingMessage);
        }

        public void Warn(string loggingMessage, [CallerMemberName] string memberName = "")
        {
            System.Diagnostics.Trace.WriteLine($"Warn Message from {memberName}");
            _logger.Warn(loggingMessage);
        }

    }
}