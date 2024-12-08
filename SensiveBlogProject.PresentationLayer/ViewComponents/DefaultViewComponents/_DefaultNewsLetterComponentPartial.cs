using Microsoft.AspNetCore.Mvc;
using SensiveBlogProject.EntityLayer.Concrete;

namespace BlogProject.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultNewsLetterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var newsLetter = new NewsLetter(); // Gerekirse buradan model doldurulur
            return View(newsLetter);
        }

    }
}
