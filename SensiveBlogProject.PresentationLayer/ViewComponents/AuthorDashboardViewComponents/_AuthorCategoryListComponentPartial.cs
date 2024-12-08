using Microsoft.AspNetCore.Mvc;
using SensiveBlogProject.BusinessLayer.Abstract;

namespace BlogProject.PresentationLayer.ViewComponents.AuthorDashboardViewComponents
{
    public class _AuthorCategoryListComponentPartial:ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _AuthorCategoryListComponentPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _categoryService.TGetAll();
            return View(value);
        }
    }
}
