using Microsoft.AspNetCore.Mvc;
using SensiveBlogProject.BusinessLayer.Abstract;

namespace SensiveBlogProject.PresentationLayer.ViewComponents.ArticleDetails
{
    public class _ArticleDetailCommentListComponentPartial :ViewComponent
    {
        private readonly ICommentService _commentService;

        public _ArticleDetailCommentListComponentPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            ViewBag.id = id;
            var values = _commentService.TGetCommentByArticleID(id);

            return View(values);
        }

    }
}
