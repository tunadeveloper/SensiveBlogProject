using Microsoft.AspNetCore.Mvc;

namespace BlogProject.PresentationLayer.ViewComponents.UILayoutViewComponents
{
    public class _UILayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
