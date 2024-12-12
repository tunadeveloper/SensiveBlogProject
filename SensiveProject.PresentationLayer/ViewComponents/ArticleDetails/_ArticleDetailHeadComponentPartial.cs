using Microsoft.AspNetCore.Mvc;

namespace SensiveProject.PresentationLayer.ViewComponents.ArticleDetails
{
	public class _ArticleDetailHeadComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
