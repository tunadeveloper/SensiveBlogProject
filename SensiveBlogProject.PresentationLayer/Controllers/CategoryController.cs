﻿using Microsoft.AspNetCore.Mvc;
using SensiveBlogProject.BusinessLayer.Abstract;
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
          _categoryService.TInsert(category);
            return RedirectToAction("Index");
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
