using SensiveBlogProject.DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using SensiveBlogProject.BusinessLayer.Abstract;
using SensiveBlogProject.EntityLayer.Concrete;

namespace BlogProject.PresentationLayer.Controllers
{
    public class NewsLetterController : Controller
    {
     private readonly INewsLetterService _newsletterService;

        public NewsLetterController(INewsLetterService newsletterService)
        {
            _newsletterService = newsletterService;
        }

        [HttpPost]
        public IActionResult Subscribe(NewsLetter newsLetter)
        {
            try
            {
                _newsletterService.TInsert(newsLetter);
                return Json(new { success = true, message = "Abonelik işlemi başarılı!" });
            }
            catch (Exception)
            {
                return Json(new { success = false, message = "Abonelik işlemi sırasında bir hata oluştu." });
            }
        }

    }
}
