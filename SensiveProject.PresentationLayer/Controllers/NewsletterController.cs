using Microsoft.AspNetCore.Mvc;
using SensiveProject.BusinessLayer.Abstract;
using SensiveProject.EntityLayer.Concrete;

namespace SensiveProject.PresentationLayer.Controllers
{
	public class NewsletterController : Controller
	{
		private readonly INewsletterService _newsletterService;

		public NewsletterController(INewsletterService newsletterService)
		{
			_newsletterService = newsletterService;
		}

		[HttpGet]
		public PartialViewResult Subscribe()
		{
			return PartialView();
		}
		[HttpPost]
		public JsonResult Subscribe(NewsLetter newsLetter)
		{
			_newsletterService.TInsert(newsLetter);
			return Json(new { success = true, message = "Başarıyla abone oldunuz." });
		}
	}
}
