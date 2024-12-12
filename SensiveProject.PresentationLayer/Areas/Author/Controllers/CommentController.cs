using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SensiveProject.BusinessLayer.Abstract;
using SensiveProject.EntityLayer.Concrete;

namespace SensiveProject.PresentationLayer.Areas.Author.Controllers
{
	[Area("Author")]
	[Route("Author/[controller]/[action]/{id?}")]
	public class CommentController : Controller
	{
		private readonly ICommentService _commentService;
		private readonly UserManager<AppUser> _userManager;
		private readonly IArticleService _articleService;

		public CommentController(ICommentService commentService, UserManager<AppUser> userManager, IArticleService articleService)
		{
			_commentService = commentService;
			_userManager = userManager;
			_articleService = articleService;
		}

		public async Task<IActionResult> CommentList()
		{
			var userValue = await _userManager.FindByNameAsync(User.Identity.Name);
			var commentList = _commentService.TGetCommentsByAppUserId(userValue.Id);
			return View(commentList);
		}

		public IActionResult DeleteComment(int id)
		{
			_commentService.TDelete(id);
			return RedirectToAction("CommentList");
		}

		[HttpGet]
		public async Task<IActionResult> EditComment(int id)
		{
			var userValue = await _userManager.FindByNameAsync(User.Identity.Name);
			var comment = _commentService.TGetCommentById(id,userValue.Id);
			return View(comment);
		}

		[HttpPost]
		public async Task<IActionResult> EditComment(Comment comment)
		{
			var userValue = await _userManager.FindByNameAsync(User.Identity.Name);

			// Mevcut yorumu getir ve güncelle
			var existingComment = _commentService.TGetCommentById(comment.CommentId, userValue.Id);
			if (existingComment == null)
			{
				return NotFound();
			}

			existingComment.Detail = comment.Detail;
			existingComment.CreatedDate = DateTime.Now;

			_commentService.TUpdate(existingComment);

			return RedirectToAction("CommentList");
		}

	}
}
