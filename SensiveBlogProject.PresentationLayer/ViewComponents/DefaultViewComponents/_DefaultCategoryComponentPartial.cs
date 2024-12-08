using BlogProject.PresentationLayer.Models;
using Microsoft.AspNetCore.Mvc;
using SensiveBlogProject.BusinessLayer.Abstract;

namespace BlogProject.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultCategoryComponentPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _DefaultCategoryComponentPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryService.TGetAllCategoriesWithArticle();

            // Entity'den ViewModel'e dönüşüm yapılıyor
            var viewModel = categories.Select(c => new CategoryWithArticleCountViewModel
            {
                CategoryName = c.CategoryName,
                ArticleCount = c.Articles.Count()
            }).ToList();

            return View(viewModel);
        }
    }
}
