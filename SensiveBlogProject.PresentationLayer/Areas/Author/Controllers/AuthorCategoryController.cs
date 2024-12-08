using Microsoft.AspNetCore.Mvc;
using SensiveBlogProject.BusinessLayer.Abstract;
using SensiveBlogProject.EntityLayer.Concrete;

namespace BlogProject.PresentationLayer.Areas.Author.Controllers
{
    [Area("Author")]
    [Route("Author/[controller]")]
    public class AuthorCategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public AuthorCategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            ViewBag.v3 = "Kategori İşlemleri";
            var values = _categoryService.TGetAll();
            return View(values);
        }

        [Route("CreateCategory")]
        public IActionResult CreateCategory()
        {
            return View();
        }


        [HttpPost]
        [Route("CreateCategory")]
        public IActionResult CreateCategory(Category category)
        {
            _categoryService.TInsert(category);
            return RedirectToAction("Index");
        }

        [Route("DeleteCategory/{id}")]
        public IActionResult DeleteCategory(int id)
        {
            _categoryService.TDelete(id);
            return RedirectToAction("Index");

        }

        [Route("UpdateCategory/{id}")]
        public IActionResult UpdateCategory(int id)
        {
            var value = _categoryService.TGetById(id);
            return View(value);
        }

        [HttpPost]
        [Route("UpdateCategory/{id}")]
        public IActionResult UpdateCategory(Category category)
        {
            _categoryService.TUpdate(category);
            return RedirectToAction("Index");
        }
    }
}
