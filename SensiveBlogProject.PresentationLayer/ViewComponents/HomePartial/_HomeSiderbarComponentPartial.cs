using Microsoft.AspNetCore.Mvc;

namespace SensiveBlogProject.PresentationLayer.ViewComponents.HomePartial
{
    public class _HomeSiderbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
