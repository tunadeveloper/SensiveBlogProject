using Microsoft.AspNetCore.Mvc;
using SensiveBlogProject.BusinessLayer.Abstract;
using SensiveBlogProject.BusinessLayer.Concrete;
using SensiveBlogProject.EntityLayer.Concrete;

namespace SensiveBlogProject.PresentationLayer.Controllers
{

    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            contact.Created = DateTime.Now;
            contact.Status = false;
            try
            {
                _contactService.TInsert(contact);
                return Json(new { success = true, message = "Mesajınız başarıyla gönderildi!" });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "Bir hata oluştu. Lütfen tekrar deneyin." });
            }
        }

    }
}
