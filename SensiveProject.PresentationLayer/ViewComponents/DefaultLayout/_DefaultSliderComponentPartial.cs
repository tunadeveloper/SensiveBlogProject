using Microsoft.AspNetCore.Mvc;
using SensiveProject.BusinessLayer.Abstract;

namespace SensiveProject.PresentationLayer.ViewComponents.DefaultLayout
{
	public class _DefaultSliderComponentPartial : ViewComponent
	{
		private readonly IArticleService _articleService;

		public _DefaultSliderComponentPartial(IArticleService articleService)
		{
			_articleService = articleService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _articleService.TArticleListWithCategoryAndAppUser().TakeLast(5).ToList();
			return View(values);
		}
	}
}
