using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SensiveProject.BusinessLayer.Abstract;
using SensiveProject.EntityLayer.Concrete;
using SensiveProject.PresentationLayer.Models;

namespace SensiveProject.PresentationLayer.Controllers
{
	[AllowAnonymous]
	public class DefaultArticleController : Controller
	{
		private readonly IArticleService _articleService;
		private readonly ICommentService _commentService;
		private readonly IArticleTagCloudService _articleTagCloudService;
		private readonly UserManager<AppUser> _userManager;

		public DefaultArticleController(IArticleService articleService, UserManager<AppUser> userManager, ICommentService commentService, IArticleTagCloudService articleTagCloudService)
		{
			_articleService = articleService;
			_userManager = userManager;
			_commentService = commentService;
			_articleTagCloudService = articleTagCloudService;
		}

		public async Task<IActionResult> ArticleDetail(int id)
		{
			ViewData["PageTitle"] = "Blog Detayı";
			ViewBag.i = id;

			var currentUser = User.Identity.IsAuthenticated ? await _userManager.FindByNameAsync(User.Identity.Name) : null;

			if (currentUser != null)
			{
				ViewBag.userId = currentUser.Id;
			}

			var currentArticle = _articleService.TGetById(id);

			if (currentArticle != null && currentArticle.AppUser != null)
			{
				ViewBag.AuthorName = $"{currentArticle.AppUser.Name} {currentArticle.AppUser.Surname}";
				ViewBag.AuthorImage = currentArticle.AppUser.ImageUrl;
				ViewBag.AuthorDetail = currentArticle.AppUser.DetailAuthor;
			}

			currentArticle.Comments = _commentService.TGetCommentsByArticleId(id);

			var previousArticle = _articleService.TGetAll()
				.Where(a => a.ArticleId < id)
				.OrderByDescending(a => a.ArticleId)
				.FirstOrDefault();

			var nextArticle = _articleService.TGetAll()
				.Where(a => a.ArticleId > id)
				.OrderBy(a => a.ArticleId)
				.FirstOrDefault();

			ViewBag.PreviousArticle = previousArticle;
			ViewBag.NextArticle = nextArticle;

			var articleTagClouds = _articleTagCloudService.TGetAllByArticleId(id);
			ViewBag.ArticleTags = articleTagClouds.Select(atc => atc.TagCloud.Title).ToList();

			return View(currentArticle);
		}

		[HttpGet]
		public PartialViewResult AddComment()
		{
			return PartialView();
		}

		[HttpPost]
		public IActionResult AddComment(Comment comment)
		{
			if (!User.Identity.IsAuthenticated)
			{
				return RedirectToAction("Index", "Login"); 
			}

			comment.CreatedDate = DateTime.Now;
				comment.Status = true;

			var article = _articleService.TGetById(comment.ArticleId);

			if (article == null)
			{
				return NotFound("İlgili makale bulunamadı.");
			}

			_commentService.TInsert(comment);

			return RedirectToAction("ArticleDetail", new { id = comment.ArticleId });
		}
	}
}
