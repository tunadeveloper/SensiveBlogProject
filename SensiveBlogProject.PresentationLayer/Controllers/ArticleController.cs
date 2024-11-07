using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SensiveBlogProject.BusinessLayer.Abstract;

namespace SensiveBlogProject.PresentationLayer.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;
        private readonly IAppUserService _appUserService;


        public ArticleController(IArticleService articleService, ICategoryService categoryService, IAppUserService appUserService)
        {
            _articleService = articleService;
            _categoryService = categoryService;
            _appUserService = appUserService;
        }

        public IActionResult ArticleList()
        {
            var values = _articleService.TGetAll();
            return View(values);
        }

        public IActionResult ArticleListWithCategory()
        {
            var values = _articleService.TArticleListWithCategory();
            return View(values);
        }

        public IActionResult ArticleListWithCategoryAndAppUser()
        {
            var values = _articleService.TArticleListWithCategoryAndAppUser();
            return View(values);
        }

        public IActionResult CreateArticle()
        {
            var categoryList = _categoryService.TGetAll();
            List<SelectListItem> values1 = (from x in categoryList
                                            select new SelectListItem
                                            {
                                                Text=x.CategoryName,
                                                Value=x.CategoryId.ToString()
                                            }
                                            ).ToList();
            ViewBag.v1 = values1;

            var appUserList = _appUserService.TGetAll();
            List<SelectListItem> values2 = (from x in appUserList
                                            select new SelectListItem
                                            {
                                                Text = x.Name + " " + x.Surname,
                                                Value = x.Id.ToString()
                                            }
                                            ).ToList();
            ViewBag.v1 = values2;
            return View();
        }
    }
}
