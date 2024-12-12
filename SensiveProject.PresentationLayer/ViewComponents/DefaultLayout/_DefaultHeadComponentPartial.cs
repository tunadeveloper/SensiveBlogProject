using Microsoft.AspNetCore.Mvc;

namespace SensiveProject.PresentationLayer.ViewComponents.DefaultLayout
{
	public class _DefaultHeadComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
