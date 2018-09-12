using System.Web.Mvc;

namespace ServerHosting.WebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "ServerHosting Co. Web API";

            return View();
        }
    }
}