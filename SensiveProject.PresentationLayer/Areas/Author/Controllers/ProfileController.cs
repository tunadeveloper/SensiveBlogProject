using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SensiveProject.EntityLayer.Concrete;
using SensiveProject.PresentationLayer.Areas.Author.Models;

namespace SensiveProject.PresentationLayer.Areas.Author.Controllers
{
	[Area("Author")]
	[Route("Author/[controller]/[action]/{id?}")]
	public class ProfileController : Controller
	{
		private readonly Microsoft.AspNetCore.Identity.UserManager<AppUser> _userManager;

		public ProfileController(Microsoft.AspNetCore.Identity.UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		[HttpGet]
		public async Task<IActionResult> Index()
		{
			var user = await _userManager.FindByNameAsync(User.Identity.Name);

			UserEditViewModel model = new UserEditViewModel();
			model.Surname = user.Surname;
			model.Email = user.Email;
			model.Name = user.Name;
			model.Username = user.UserName;
			model.ImageUrl = user.ImageUrl;
			model.AuthorDetail = user.DetailAuthor;

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Index(UserEditViewModel model)
		{
			var user = await _userManager.FindByNameAsync(User.Identity.Name);

			user.Surname = model.Surname;
			user.Name = model.Name;
			user.Email = model.Email;
			user.UserName = model.Username;
			user.DetailAuthor = model.AuthorDetail;

			if (model.Image != null)
			{
				var resource = Directory.GetCurrentDirectory();
				var extension = Path.GetExtension(model.Image.FileName);
				var imageName = Guid.NewGuid() + extension;
				var saveLocation = resource + "/wwwroot/userImages/" + imageName;
				using (var stream = new FileStream(saveLocation, FileMode.Create))
				{
					await model.Image.CopyToAsync(stream);
				}
				user.ImageUrl = "/userImages/" + imageName;
			}

			else
			{
				// Yeni fotoğraf seçilmemişse eski fotoğrafı koruyun
				user.ImageUrl = user.ImageUrl ?? "/wwwroot/userImages/f5f862d0-26ec-4e57-885e-294082c4627e.jpg.jpg";
			}

			user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.Password);
			var result = await _userManager.UpdateAsync(user);

			if (result.Succeeded)
			{
				RedirectToAction("Index", "Login");
			}
			else
			{
				return View();
			}
			return View(model);
		}
	}
}
