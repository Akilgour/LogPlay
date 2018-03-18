using LogPlay.Logging.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogPlay.Helpers
{
    public static class StaticLogHelper
    {
        public static string Resolve(IXeretecLogging logging, string orderId)
        {

            logging.Entering();

            logging.Fatal("Highest level: important stuff down");
            logging.Error("For example application crashes / exceptions.");
            logging.Warn("Incorrect behavior but the application can continue");
            logging.Info("Normal behavior like mail sent, user updated profile etc.");
            logging.Debug("Executed queries, user authenticated, session expired");
            logging.Trace("Begin method X, end method X etc");

            return "StaticLogHelper Resolve";
        }

    }
}