using Microsoft.AspNetCore.Mvc;
using SensiveBlogProject.BusinessLayer.Abstract;

namespace SensiveBlogProject.PresentationLayer.ViewComponents
{
    public class _ArticleListComponentPartial:ViewComponent
    {
        private readonly IArticleService _articleService;

        public _ArticleListComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _articleService.TArticleListWithCategoryAndAppUser();
            return View(values);
        }
    }
}
