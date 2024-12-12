using Microsoft.AspNetCore.Mvc;

namespace SensiveProject.PresentationLayer.ViewComponents.DefaultLayout
{
	public class _DefaultNavbarComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
