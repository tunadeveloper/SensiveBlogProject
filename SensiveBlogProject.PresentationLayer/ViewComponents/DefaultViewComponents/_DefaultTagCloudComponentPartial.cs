using Microsoft.AspNetCore.Mvc;
using SensiveBlogProject.BusinessLayer.Abstract;

namespace BlogProject.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultTagCloudComponentPartial : ViewComponent
    {
        private readonly ITagCloudService _tagCloudService;

        public _DefaultTagCloudComponentPartial(ITagCloudService tagCloudService)
        {
            _tagCloudService = tagCloudService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _tagCloudService.TGetAll();
            return View(values);
        }
    }
}
