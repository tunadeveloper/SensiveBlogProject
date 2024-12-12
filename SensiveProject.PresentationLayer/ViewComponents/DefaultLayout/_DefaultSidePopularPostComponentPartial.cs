using Microsoft.AspNetCore.Mvc;
using SensiveProject.BusinessLayer.Abstract;

namespace SensiveProject.PresentationLayer.ViewComponents.DefaultLayout
{
	public class _DefaultSidePopularPostComponentPartial : ViewComponent
	{
		private readonly IArticleService _articleService;

		public _DefaultSidePopularPostComponentPartial(IArticleService articleService)
		{
			_articleService = articleService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _articleService.TArticleListWithCategoryAndAppUser().TakeLast(3).ToList();
			return View(values); 
		}
	}
}
