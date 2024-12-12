using Microsoft.AspNetCore.Mvc;
using SensiveProject.BusinessLayer.Abstract;

namespace SensiveProject.PresentationLayer.ViewComponents.DefaultLayout
{
	public class _DefaultContactInfoComponentPartial : ViewComponent
	{
		private readonly IContactInfoService _contactInfoService;

		public _DefaultContactInfoComponentPartial(IContactInfoService contactInfoService)
		{
			_contactInfoService = contactInfoService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _contactInfoService.TGetAll();
			return View(values);
		}
	}
}
