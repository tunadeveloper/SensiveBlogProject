using Microsoft.AspNetCore.Mvc;
using SensiveProject.BusinessLayer.Abstract;
using SensiveProject.EntityLayer.Concrete;

namespace SensiveProject.PresentationLayer.Controllers
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
			ViewData["PageTitle"] = "İletişim";

			return View();
		}

		[HttpGet]
		public PartialViewResult SendContactMessage()
		{
			return PartialView();
		}
		[HttpPost]
		public IActionResult SendContactMessage(Contact contact)
		{
			contact.Status = true;
			_contactService.TInsert(contact);	
			return RedirectToAction("Index");
		}
	}
}
