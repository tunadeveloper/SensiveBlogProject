using Microsoft.AspNetCore.Mvc;
using SensiveBlogProject.BusinessLayer.Abstract;
using SensiveBlogProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
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
            if (!User.Identity.IsAuthenticated)
            {
                return Json(new
                {
                    success = false,
                    message = "Yorum eklemek için giriş yapmalısınız.",
                    redirect = "/Login/Index"
                });
            }

            string userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!int.TryParse(userIdString, out int userId))
            {
                return Json(new { success = false, message = "Kullanıcı ID'si doğru formatta değil." });
            }

            comment.AppUserId = userId;
            comment.Status = true;
            comment.CreatedDate = DateTime.Now;

            try
            {
                _commentService.TInsert(comment);
                return Json(new { success = true, message = "Yorumunuz başarıyla eklendi!" });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = $"Yorum eklenirken bir hata oluştu: {ex.Message}" });
            }

           
        }


    }
}
