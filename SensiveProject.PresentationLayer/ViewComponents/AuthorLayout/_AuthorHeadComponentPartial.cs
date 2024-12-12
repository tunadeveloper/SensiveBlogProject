using Microsoft.AspNetCore.Mvc;

namespace SensiveProject.PresentationLayer.ViewComponents.AuthorLayout
{
	public class _AuthorHeadComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
