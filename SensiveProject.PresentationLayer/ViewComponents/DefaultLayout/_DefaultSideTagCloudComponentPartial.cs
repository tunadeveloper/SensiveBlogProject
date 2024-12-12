using Microsoft.AspNetCore.Mvc;
using SensiveProject.BusinessLayer.Abstract;

namespace SensiveProject.PresentationLayer.ViewComponents.DefaultLayout
{
	public class _DefaultSideTagCloudComponentPartial : ViewComponent
	{
		private readonly ITagCloudService _tagCloudService;

		public _DefaultSideTagCloudComponentPartial(ITagCloudService tagCloudService)
		{
			_tagCloudService = tagCloudService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _tagCloudService.TGetAll().Take(8).ToList();
			return View(values);
		}
	}
}
