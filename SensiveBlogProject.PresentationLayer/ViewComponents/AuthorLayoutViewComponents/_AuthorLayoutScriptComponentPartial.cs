using Microsoft.AspNetCore.Mvc;

namespace BlogProject.PresentationLayer.ViewComponents.AuthorLayoutViewComponents
{
    public class _AuthorLayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
