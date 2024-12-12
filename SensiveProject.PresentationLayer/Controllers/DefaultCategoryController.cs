using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SensiveProject.BusinessLayer.Abstract;


namespace SensiveProject.PresentationLayer.Controllers
{
	[AllowAnonymous]
	public class DefaultCategoryController : Controller
	{
		private readonly IArticleService _articleService;

		public DefaultCategoryController(IArticleService articleService)
		{
			_articleService = articleService;
		}


		public IActionResult Index(int? page)
		{
			ViewData["PageTitle"] = "Kategoriler";

			int pageNumber = page ?? 1; 
			int pageSize = 6;

			var values = _articleService.TArticleListWithCategoryAndAppUser();

			var pagedArticles = values
				.Skip((pageNumber - 1) * pageSize) 
				.Take(pageSize)      
				.ToList();       

			ViewBag.CurrentPage = pageNumber;

			ViewBag.PageCount = Math.Ceiling(values.Count() / (double)pageSize);

			return View(pagedArticles);
		}

	}
}
