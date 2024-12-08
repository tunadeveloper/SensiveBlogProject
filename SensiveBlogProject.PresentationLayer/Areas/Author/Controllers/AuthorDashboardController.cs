using SensiveBlogProject.DataAccessLayer.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SensiveBlogProject.EntityLayer.Concrete;

namespace BlogProject.PresentationLayer.Areas.Author.Controllers
{

    [Area("Author")]
    [Route("Author/[controller]")]
    public class AuthorDashboardController : Controller
    {
        private readonly SensiveContext _blogContext;
        private readonly UserManager<AppUser> _userManager;
        public AuthorDashboardController(SensiveContext blogContext, UserManager<AppUser> userManager)
        {
            _blogContext = blogContext;
            _userManager = userManager;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var userCount = _blogContext.Users.Count();
            ViewBag.usercount = userCount;

            var articleCount = _blogContext.Articles.Count();
            ViewBag.articlecount = articleCount;

            var categoryCount = _blogContext.Categories.Count();
            ViewBag.categorycount = categoryCount;

            var user = await _userManager.GetUserAsync(User);

            if (user != null)
            {
                // Kullanıcının yaptığı yorumların sayısını çekin
                var commentCount = _blogContext.Comments
                                           .Count(c => c.AppUserId == user.Id);

                // ViewBag'e aktarın
                ViewBag.CommentCount = commentCount;
            }
            else
            {
                ViewBag.CommentCount = 0;
            }



            return View();
        }


    }
}
