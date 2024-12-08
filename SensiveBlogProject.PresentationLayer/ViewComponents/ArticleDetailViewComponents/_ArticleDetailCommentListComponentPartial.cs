using Microsoft.AspNetCore.Mvc;
using SensiveBlogProject.BusinessLayer.Abstract;

namespace BlogProject.PresentationLayer.ViewComponents.ArticleDetailViewComponents
{
    public class _ArticleDetailCommentListComponentPartial : ViewComponent
    {
        private readonly ICommentService _commentService;
        private readonly IArticleService _articleService;
        public _ArticleDetailCommentListComponentPartial(ICommentService commentService, IArticleService articleService)
        {
            _commentService = commentService;
            _articleService = articleService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var comment = _commentService.TGetCommentListByArticleId(id);
            ViewBag.Comment = comment.Count();
            return View(comment);
        }
    }
}
