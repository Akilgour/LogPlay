using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LogPlay.Controllers
{
    public class UncatchedErrorController : Controller
    {
        // GET: UncatchedError
        public ActionResult Index()
        {
            return View();
        }

        public void ThrowNewException()
        {
            throw new Exception();
        }
    }
}