using Microsoft.AspNetCore.Mvc;
using SensiveBlogProject.BusinessLayer.Abstract;
using SensiveBlogProject.EntityLayer.Concrete;

namespace BlogProject.PresentationLayer.Controllers
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
            ViewBag.v1 = "İletişim";
            ViewBag.v2 = "Gönder Gelsin!";
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            try
            {
                contact.Created = DateTime.Now;
                _contactService.TInsert(contact);
                return Json(new { success = true, message = "Mesajını Aldık!" });
            }
            catch (Exception)
            {
                return Json(new { success = false, message = "Mesaj Gönderme işlemi sırasında bir hata oluştu." });
            }
          

            return View();
        }
    }
}
