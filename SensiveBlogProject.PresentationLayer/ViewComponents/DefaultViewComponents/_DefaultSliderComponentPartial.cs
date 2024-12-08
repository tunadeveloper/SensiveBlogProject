using Microsoft.AspNetCore.Mvc;
using SensiveBlogProject.BusinessLayer.Abstract;

namespace BlogProject.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultSliderComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleService;

        public _DefaultSliderComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _articleService.TLastTake5ListArticlesWithCategory();
            return View(values);
        }
    }
}
