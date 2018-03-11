using LogPlay.Helpers;
using LogPlay.Logging.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LogPlay.Controllers
{
    public class InjectedLoggingController : Controller
    {
        private readonly IXeretecLogging _logging;

        public InjectedLoggingController(IXeretecLogging logging)
        {
            _logging = logging;
        }

        // GET: InjectedLogging
        public ActionResult Index( )
        {
            //_logging.Fatal("Highest level: important stuff down");
            //_logging.Error("For example application crashes / exceptions.");
            //_logging.Warn("Incorrect behavior but the application can continue");
            //_logging.Info("Normal behavior like mail sent, user updated profile etc.");
            //_logging.Debug("Executed queries, user authenticated, session expired");
            //_logging.Trace("Begin method X, end method X etc");

            return View();
        }
        
        public ActionResult StaticLogHelperAction(string orderId)
        {
            StaticLogHelper.Resolve(_logging, orderId);
            return RedirectToAction("Index");
        }        
    }
}