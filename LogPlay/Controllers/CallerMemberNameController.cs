using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web.Mvc;

namespace LogPlay.Controllers
{
    public class CallerMemberNameController : Controller
    {
        // GET: CallerMemberName
        public ActionResult Index()
        {
            Trace.WriteLine("Entering CallerMemberNameController.Index ");
            LevelOne();
            return View();
        }

        private void LevelOne([CallerMemberName] string memberName = "")
        {
            Trace.WriteLine("Entering CallerMemberNameController.LevelOne ");
            Trace.WriteLine($"memberName{memberName}");
            LevelTwo("foo");
            Trace.WriteLine("Exiting CallerMemberNameController.LevelOne ");
        }

        private void LevelTwo(string value, [CallerMemberName] string memberName = "")
        {
            Trace.WriteLine("Entering CallerMemberNameController.LevelTwo ");
            Trace.WriteLine($"value {value}");
            Trace.WriteLine($"memberName {memberName}");
            Trace.WriteLine("Exiting CallerMemberNameController.LevelTwo ");
        }
    }
}