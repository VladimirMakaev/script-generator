using System.Web.Mvc;
using EmbassyRegistration.Form.App_Start;
using EmbassyRegistration.Form.Engine;
using EmbassyRegistration.Form.Engine.Models;

namespace VisaApplicationForm.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View(new ApplicationModel());
        }

        [HttpPost]
        public ActionResult Index(ApplicationModel model)
        {
            var generator = new ScriptGenerator(HttpContext.Server.MapPath(Configuration.TemplatePath), Configuration.ScriptsStoragePath);

            generator.Generate(model);
            return RedirectToAction("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
