using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json.Linq;
using SensiveBlogProject.BusinessLayer.Abstract;
using SensiveBlogProject.EntityLayer.Concrete;

namespace BlogProject.PresentationLayer.Areas.Author.Controllers
{
    [Area("Author")]
    [Route("Author/[controller]")]
    public class AuthorContentsController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly UserManager<AppUser> _userManager;
        private readonly ICategoryService _categoryService;

        public AuthorContentsController(IArticleService articleService, UserManager<AppUser> userManager, ICategoryService categoryService)
        {
            _articleService = articleService;
            _userManager = userManager;
            _categoryService = categoryService;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            if (user != null)
            {
                var articles = _articleService.TGetArticleListByAppUserId(user.Id);

                return View(articles); 
            }

            return View(new List<Article>()); // Kullanıcı yoksa boş liste gönderir
        }

        [Route("UpdateContent/{id}")]
        public IActionResult UpdateContent(int id)
        {
            var article = _articleService.TGetById(id);

            var categories = _categoryService.TGetAll();

            List<SelectListItem> categoryList = categories.Select(x => new SelectListItem
            {
                Text = x.CategoryName, 
                Value = x.CategoryId.ToString(), 
                Selected = article.CategoryId == x.CategoryId 
            }).ToList();

            ViewBag.CategoryList = categoryList;

            return View(article);
        }

        [HttpPost]
        [Route("UpdateContent/{id}")]
        public async Task<IActionResult> UpdateContent(Article article)
        {
            var userValue = await _userManager.FindByNameAsync(User.Identity.Name);
            article.AppUserId = userValue.Id;
            _articleService.TUpdate(article);
            return RedirectToAction("Index");
        }

    }
}
