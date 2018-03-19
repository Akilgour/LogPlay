using LogPlay.Helpers;
using LogPlay.Logging.Interface;
using LogPlay.Service;
using LogPlay.Service.Interface;
using System.Web.Mvc;

namespace LogPlay.Controllers
{
    public class InjectedLoggingController : Controller
    {
        private readonly IXeretecLogging _logging;
        private readonly IPersonService _personService;

        public InjectedLoggingController(IXeretecLogging logging)
        {
            _logging = logging;
            _personService = new PersonService(_logging);
        }

        // GET: InjectedLogging
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StaticLogHelperAction(string orderId)
        {
            StaticLogHelper.Resolve(_logging, orderId);
            return RedirectToAction("Index");
        }

        public ActionResult InstanceLogHelperAction(string orderId)
        {
            var instanceLogHelper = new InstanceLogHelper(_logging);
            instanceLogHelper.Resolve(orderId);
            return RedirectToAction("Index");
        }

        public ActionResult ExitingLogHelperAction()
        {
            var person = _personService.GetPersonById(1);
            return RedirectToAction("Index");
        }

        public ActionResult HandledExceptionLoggingAction()
        {
            ExceptionHelper.HandledException(_logging, 1, "Rocky Raccoon");
            return RedirectToAction("Index");
        }
    }
}