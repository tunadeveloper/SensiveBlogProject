using Microsoft.AspNetCore.Mvc;
using SensiveBlogProject.BusinessLayer.Abstract;

namespace SensiveBlogProject.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IArticleService _articleService;

        public DefaultController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IActionResult ArticleList()
        {
            var values = _articleService.TArticleListWithCategoryAndAppUser();
            return View(values);
        }

    }
}
