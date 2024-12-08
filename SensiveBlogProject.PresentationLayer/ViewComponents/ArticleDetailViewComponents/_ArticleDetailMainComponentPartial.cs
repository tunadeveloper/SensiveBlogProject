using Microsoft.AspNetCore.Mvc;
using SensiveBlogProject.BusinessLayer.Abstract;

namespace BlogProject.PresentationLayer.ViewComponents.ArticleDetailViewComponents
{
    public class _ArticleDetailMainComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleService;

        public _ArticleDetailMainComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var value = _articleService.TGetArticleByIdWithTagCloudAndAppUser(id);
           
            return View(value);
        }
    }
}
