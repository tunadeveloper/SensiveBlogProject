using Microsoft.AspNetCore.Mvc;

namespace BlogProject.PresentationLayer.Controllers
{
    public class AuthorLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
