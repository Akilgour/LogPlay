using NLog;
using System.Web.Mvc;

namespace LogPlay.Controllers
{
    public class HardCodedLogFourNetController : Controller
    {
        // GET: HardCoded
        public ActionResult Index()
        {
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