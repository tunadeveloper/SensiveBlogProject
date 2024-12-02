using Microsoft.AspNetCore.Mvc;
using SensiveBlogProject.BusinessLayer.Abstract;

namespace SensiveBlogProject.PresentationLayer.ViewComponents.HomePartial
{
    public class _HomeBlogListComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleService;

        public _HomeBlogListComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke() {
            var values = _articleService.TGetRandomArticleList();
            return View(values);
        }
    }
}
