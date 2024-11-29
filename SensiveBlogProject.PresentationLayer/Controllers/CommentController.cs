using Microsoft.AspNetCore.Mvc;
using SensiveBlogProject.BusinessLayer.Abstract;
using SensiveBlogProject.EntityLayer.Concrete;

namespace SensiveBlogProject.PresentationLayer.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public PartialViewResult AddComment(int id)
        {
            ViewBag.id = id;

            return PartialView();
        }


        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {
            comment.CreatedDate = DateTime.Now;
            //comment.ArticleId = 0;
            comment.AppUserId = 1;

            _commentService.TInsert(comment);
            return RedirectToAction("ArticleList","Default");
        }
    }
}
