using Microsoft.AspNetCore.Mvc;
using SensiveBlogProject.BusinessLayer.Abstract;

namespace SensiveBlogProject.PresentationLayer.ViewComponents.ArticleDetails
{
    public class _ArticleDetailListComponentPartial:ViewComponent
    {
        private readonly IArticleService _articleService;

        public _ArticleDetailListComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke(int id)
        {
            id = 5;
            var value = _articleService.TGetById(id);
            return View(value);
        }
    }
}
