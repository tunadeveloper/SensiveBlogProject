using Microsoft.AspNetCore.Mvc;
using SensiveProject.BusinessLayer.Abstract;

namespace SensiveProject.PresentationLayer.ViewComponents.DefaultLayout
{
	public class _DefaultSideCategoryListComponentPartial : ViewComponent
	{
		private readonly ICategoryService _categoryService;

		public _DefaultSideCategoryListComponentPartial(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

		public IViewComponentResult Invoke()
		{
			var values=_categoryService.TGetCategoryWithArticle().TakeLast(6).ToList();
			return View(values);
		}
	}
}
