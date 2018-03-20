using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;
using LogPlay.Helpers;

namespace LogPlay.Controllers
{
    public class SendGridController : Controller
    {
        // GET: SendGrid
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SendEmail()
        {
            SendEmailHelper.Execute().Wait();
            return RedirectToAction("Index");
        }
    }
}