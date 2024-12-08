using BlogProject.PresentationLayer.Areas.Author.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SensiveBlogProject.EntityLayer.Concrete;

namespace BlogProject.PresentationLayer.Areas.Author.Controllers
{
    [Area("Author")]
    [Route("Author/[controller]")]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("Index")]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, false, true);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "AuthorProfile", new { Area = "Author" });
            }
            else
            {
                return View();
            }

        }

        [HttpGet]
        [Route("Logout")]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync(); // Oturumu kapat
            return RedirectToAction("Index", "Login",new { areas = "Author"}); // Yönlendirme
        }



    }
}
