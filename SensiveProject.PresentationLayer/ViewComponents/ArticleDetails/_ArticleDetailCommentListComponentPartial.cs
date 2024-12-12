using Microsoft.AspNetCore.Mvc;
using SensiveProject.BusinessLayer.Abstract;

namespace SensiveProject.PresentationLayer.ViewComponents.ArticleDetails
{
	public class _ArticleDetailCommentListComponentPartial : ViewComponent
	{
		private readonly ICommentService _commentService;

		public _ArticleDetailCommentListComponentPartial(ICommentService commentService)
		{
			_commentService = commentService;
		}

		public IViewComponentResult Invoke(int id)
		{
			var value = _commentService.TGetCommentsByArticleId(id);
			return View(value);
		}
	}
}
