using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SensiveBlogProject.BusinessLayer.Abstract;
using SensiveBlogProject.DataAccessLayer.Context;
using SensiveBlogProject.EntityLayer.Concrete;
using System.Reflection.PortableExecutable;

namespace SensiveBlogProject.PresentationLayer.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _ArticleService;
        private readonly ICategoryService _categoryService;
        private readonly IAppUserService _appUserService;
        private readonly ICommentService _commentService;
        public ArticleController(IArticleService articleService, ICategoryService categoryService, IAppUserService appUserService,ICommentService commentService)
        {
            _ArticleService = articleService;
            _categoryService = categoryService;
            _appUserService = appUserService;
            _commentService = commentService;

        }

        public IActionResult Index()
        {
            var values = _ArticleService.TArticleListWithCategoryAndAppUser();
            return View(values);
        }

        public IActionResult CreateArticle()
        {
            List<SelectListItem> kategori = (from i in _categoryService.TGetAll()
                                             select new SelectListItem
                                             {
                                                 Text = i.CategoryName,
                                                 Value = i.CategoryId.ToString()
                                             }).ToList();
            ViewBag.v1 = kategori;

            List<SelectListItem> kullanici = (from i in _appUserService.TGetAll()
                                             select new SelectListItem
                                             {
                                                 Text = i.Name+" "+i.Surname,
                                                 Value = i.Id.ToString()
                                             }).ToList();
            ViewBag.v2 = kullanici;

            return View();
        }

        [HttpPost]
        public IActionResult CreateArticle(Article Article)
        {
            Article.CreatedDate =DateTime.Now;
            _ArticleService.TInsert(Article);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteArticle(int id)
        {
            _ArticleService.TDelete(id);
            return RedirectToAction("Index");
        }
        public IActionResult UpdateArticle(int id)
        {
            List<SelectListItem> kategori = (from i in _categoryService.TGetAll()
                                             select new SelectListItem
                                             {
                                                 Text = i.CategoryName,
                                                 Value = i.CategoryId.ToString()
                                             }).ToList();
            ViewBag.v1 = kategori;

            List<SelectListItem> kullanici = (from i in _appUserService.TGetAll()
                                              select new SelectListItem
                                              {
                                                  Text = i.Name + " " + i.Surname,
                                                  Value = i.Id.ToString()
                                              }).ToList();
            ViewBag.v2 = kullanici;
            var values = _ArticleService.TGetById(id);

         
            return View(values);
        }


        [HttpPost]
        public IActionResult UpdateArticle(Article Article)
        {
         

            _ArticleService.TUpdate(Article);
            return RedirectToAction("Index");
        }


        public IActionResult ArticleDetail(int id)
        {
            ViewBag.id = id;
            var value = _ArticleService.TGetById(id);
            return View(value);
        }


    }
}
