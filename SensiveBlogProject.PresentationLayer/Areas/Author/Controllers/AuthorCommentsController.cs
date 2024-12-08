using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SensiveBlogProject.BusinessLayer.Abstract;
using SensiveBlogProject.EntityLayer.Concrete;

namespace BlogProject.PresentationLayer.Areas.Author.Controllers
{
    [Area("Author")]
    [Route("Author/[controller]")]
    public class AuthorCommentsController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly UserManager<AppUser> _userManager;

        public AuthorCommentsController(ICommentService commentService, UserManager<AppUser> userManager)
        {
            _commentService = commentService;
            _userManager = userManager;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            if (user != null)
            {
                var comments = _commentService.TGetCommentListByAppUserId(user.Id);

                return View(comments); 
            }

            return View(new List<Article>()); 
        }

		[Route("DeleteComment")]
		public IActionResult DeleteComment(int id)
		{
			_commentService.TDelete(id);
			return RedirectToAction("Index");
		}


		[HttpGet]
		[Route("UpdateComment/{id}")]
		public IActionResult UpdateComment(int id)
		{
			var comment = _commentService.TGetById(id);
			return View(comment);
		}

		[HttpPost]
		[Route("UpdateComment/{id}")]
		public async Task<IActionResult> UpdateComment(Comment comment)
		{
			var userValue = await _userManager.FindByNameAsync(User.Identity.Name);

		
			var existingComment = _commentService.TGetById(comment.CommentId);

			if (existingComment == null)
			{
				return NotFound(); 
			}

			existingComment.Detail = comment.Detail;
			existingComment.CreatedDate = DateTime.Now;
			existingComment.AppUserId = userValue.Id;

		
			_commentService.TUpdate(existingComment);

			return RedirectToAction("Index");
		}
	}
}
