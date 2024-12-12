using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SensiveProject.BusinessLayer.Abstract;
using SensiveProject.EntityLayer.Concrete;

namespace SensiveProject.PresentationLayer.Controllers
{
	[AllowAnonymous]
	public class DefaultController : Controller
	{
		private readonly IArticleService _articleService;
		private readonly IArticleTagCloudService _articleTagCloudService;
		private readonly ITagCloudService _tagCloudService;

		public DefaultController(IArticleService articleService, IArticleTagCloudService articleTagCloudService, ITagCloudService tagCloudService)
		{
			_articleService = articleService;
			_articleTagCloudService = articleTagCloudService;
			_tagCloudService = tagCloudService;
		}

		public IActionResult HomePage(int page = 1, int pageSize = 6)
		{
			ViewBag.BannerTitle = "Fikirlerin buluştuğu bu blogda keşfe çıkmaya hazır mısınız?";
			ViewBag.BannerSubtitle = "Yeni fikirler ve ilham dolu bir yolculuğa başlayın!";

			var values = _articleService.TArticleListWithCategoryAndAppUser()
								.ToList()
								.Skip((page - 1) * pageSize)
								.Take(pageSize)
								.ToList();

			foreach (var article in values)
			{
				article.Tags = article.ArticleTagClouds.Select(at => at.TagCloud).ToList();
			}

			ViewBag.CurrentPage = page; 
			ViewBag.TotalPages = (int)Math.Ceiling((double)_articleService.TArticleListWithCategoryAndAppUser().Count() / pageSize);

			return View(values);
		}

	}
}
