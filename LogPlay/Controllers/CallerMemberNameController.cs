using LogPlay.Helpers;
using LogPlay.Helpers.Interface;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web.Mvc;

namespace LogPlay.Controllers
{
    public class CallerMemberNameController : Controller
    {
        private readonly ICallerMemberNameHelper _callerMemberNameHelper;

        public CallerMemberNameController()
        {
            Trace.WriteLine("Entering CallerMemberNameController.Ctor ");
            _callerMemberNameHelper = new CallerMemberNameHelper();
            Trace.WriteLine("Exiting CallerMemberNameController.Ctor ");

        }


        // GET: CallerMemberName
        public ActionResult Index()
        {
            Trace.WriteLine("Entering CallerMemberNameController.Index ");
            LevelOne();
            return View();
        }

        private void LevelOne([CallerMemberName] string memberName = "")
        {
            Trace.WriteLine($"Entering CallerMemberNameController.LevelOne called from {memberName}");
            LevelTwo("foo");
            Trace.WriteLine("Exiting CallerMemberNameController.LevelOne ");
        }

        private void LevelTwo(string value, [CallerMemberName] string memberName = "")
        {
            Trace.WriteLine($"Entering CallerMemberNameController.LevelTwo called from {memberName}");
            Trace.WriteLine($"value {value}");
            _callerMemberNameHelper.ResolveWithParameter("bar");
            _callerMemberNameHelper.ResolveWithoutParameter();
            Trace.WriteLine("Exiting CallerMemberNameController.LevelTwo ");
        }
    }
}