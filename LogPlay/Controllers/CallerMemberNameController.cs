using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LogPlay.Controllers
{
    public class CallerMemberNameController : Controller
    {
        // GET: CallerMemberName
        public ActionResult Index()
        {
            System.Diagnostics.Trace.WriteLine("Entering CallerMemberNameController.Index ");
            LevelOne();
            return View();
        }

        private void LevelOne([System.Runtime.CompilerServices.CallerMemberName] string memberName = "")
        {
            System.Diagnostics.Trace.WriteLine("Entering CallerMemberNameController.LevelOne ");
            System.Diagnostics.Trace.WriteLine($"memberName{memberName}");
            LevelTwo("foo");
            System.Diagnostics.Trace.WriteLine("Exiting CallerMemberNameController.LevelOne ");

        }

        private void LevelTwo(string value, [System.Runtime.CompilerServices.CallerMemberName] string memberName = "")
        {
            System.Diagnostics.Trace.WriteLine("Entering CallerMemberNameController.LevelTwo ");
            System.Diagnostics.Trace.WriteLine($"value {value}");
            System.Diagnostics.Trace.WriteLine($"memberName {memberName}");
            System.Diagnostics.Trace.WriteLine("Exiting CallerMemberNameController.LevelTwo ");
        }
    }
}