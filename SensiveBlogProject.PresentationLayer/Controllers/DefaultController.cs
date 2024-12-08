using Microsoft.AspNetCore.Mvc;

namespace BlogProject.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Ana Sayfa";
            ViewBag.v2 = "Genel Bakış";

            return View();
        }
    }
}
