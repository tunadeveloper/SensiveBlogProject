using Microsoft.AspNetCore.Mvc;

namespace BlogProject.PresentationLayer.ViewComponents.UILayoutViewComponents
{
    public class _UILayoutHeadComponentPartial :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
