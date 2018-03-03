using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LogPlay.Controllers
{
    public class HardCodedLogFourNetController : Controller
    {
        // GET: HardCoded
        public ActionResult Index()
        {
            var config = new NLog.Config.LoggingConfiguration();
            var logfile = new NLog.Targets.FileTarget() { FileName = "file.txt", Name = "logfile" };
            config.LoggingRules.Add(new NLog.Config.LoggingRule("*", LogLevel.Debug, logfile));
            LogManager.Configuration = config;
            ILogger logger = LogManager.GetCurrentClassLogger();

            logger.Fatal("Highest level: important stuff down");
            logger.Error("For example application crashes / exceptions.");
            logger.Warn("Incorrect behavior but the application can continue");
            logger.Info("Normal behavior like mail sent, user updated profile etc.");
            logger.Debug("Executed queries, user authenticated, session expired");
            logger.Trace("Begin method X, end method X etc");

            return View();
        }
    }
}