using Microsoft.AspNetCore.Mvc;
using SensiveBlogProject.BusinessLayer.Abstract;

namespace BlogProject.PresentationLayer.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IActionResult ArticleDetail(int id)
        {
            ViewBag.id = id;
            var value = _articleService.TGetById(id);
            return View(value);
        }
    }
}
