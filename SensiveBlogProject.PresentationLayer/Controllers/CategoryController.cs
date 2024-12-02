using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using SensiveBlogProject.BusinessLayer.Abstract;
using SensiveBlogProject.BusinessLayer.ValidationRules.CategoryValidationRules;
using SensiveBlogProject.EntityLayer.Concrete;

namespace SensiveBlogProject.PresentationLayer.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var values = _categoryService.TGetAll();
            return View(values);
        }

        public IActionResult CreateCategory()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            ModelState.Clear();
            CreateCategoryValidator validationRules = new CreateCategoryValidator();
            ValidationResult result = validationRules.Validate(category);
            if (result.IsValid)
            {
                _categoryService.TInsert(category);
                return RedirectToAction("CategoryList");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }
        public IActionResult DeleteCategory(int id)
        {
            _categoryService.TDelete(id);
            return RedirectToAction("Index");
        }
        public IActionResult UpdateCategory(int id)
        {
            var values = _categoryService.TGetById(id);
           
            return View(values);
        }


        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
      
            _categoryService.TUpdate(category);
            return RedirectToAction("Index");
        }

    }
}
