using Microsoft.AspNetCore.Mvc;

namespace SensiveBlogProject.PresentationLayer.ViewComponents
{
    public class _ArticleListHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
