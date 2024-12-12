using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SensiveProject.BusinessLayer.Abstract;
using SensiveProject.EntityLayer.Concrete;

namespace SensiveProject.PresentationLayer.Areas.Author.Controllers
{
	[Area("Author")]
	[Route("Author/[controller]/[action]/{id?}")]
	public class DashboardController : Controller
	{
		private readonly UserManager<AppUser> _userManager;
		private readonly IAppUserService _appUserService;
		private readonly IArticleService _articleService;
		private readonly ICommentService _commentService;

		public DashboardController(UserManager<AppUser> userManager, IAppUserService appUserService, IArticleService articleService, ICommentService commentService)
		{
			_userManager = userManager;
			_appUserService = appUserService;
			_articleService = articleService;
			_commentService = commentService;
		}

		public async Task<IActionResult> Index()
		{
			// Giriş yapmış kullanıcı var mı?
			var currentUser = User.Identity.IsAuthenticated ? await _userManager.FindByNameAsync(User.Identity.Name) : null;

			// Giriş yapan kullanıcı varsa, bilgilerini ViewBag'e ekleyin.
			if (currentUser != null)
			{
				ViewBag.userId = currentUser.Id;
				ViewBag.AuthorName = $"{currentUser.Name} {currentUser.Surname}";
				ViewBag.AuthorImage = currentUser.ImageUrl;
			}

			ViewBag.userCount = _appUserService.TGetAll().Count();
			ViewBag.articleCount = _articleService.TGetAll().Count();
			ViewBag.commentCount = _commentService.TGetAll().Count();

			var values = _articleService.TGetLastArticle();

			return View(values);
		}
	}
}
