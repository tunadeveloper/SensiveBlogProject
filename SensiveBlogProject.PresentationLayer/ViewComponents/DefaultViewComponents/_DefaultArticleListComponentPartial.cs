using Microsoft.AspNetCore.Mvc;
using SensiveBlogProject.BusinessLayer.Abstract;

namespace BlogProject.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultArticleListComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleService;

        public _DefaultArticleListComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke(int page = 1, int pageSize = 3)
        {
            var totalArticles = _articleService.TGetAll();
            var articles = totalArticles
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            ViewBag.TotalPages = (int)Math.Ceiling(totalArticles.Count / (double)pageSize);
            ViewBag.CurrentPage = page;

            return View(articles);
        }
    }
}
