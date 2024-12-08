
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SensiveBlogProject.EntityLayer.Concrete;

namespace BlogProject.PresentationLayer.Areas.Author.Controllers
{
    [Area("Author")]
    [Route("Author/[controller]")]
    public class AuthorProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public AuthorProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            UserViewModel model = new UserViewModel();
            model.Surname = user.Surname;
            model.Email = user.Email;
            model.Name = user.Name;
            model.Username = user.UserName;
            model.ImageUrl = user.ImageUrl;
            model.Description = user.Description;

            return View(model);
        }

        [HttpPost]
        [Route("Index")]
        public async Task<IActionResult> Index(UserViewModel model)
        {
            // Model doğruluğunu kontrol edin
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Kullanıcıyı bulun
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (user == null)
            {
                ModelState.AddModelError("", "Kullanıcı bulunamadı.");
                return View(model);
            }

            // Kullanıcı bilgilerini güncelleyin
            user.Surname = model.Surname;
            user.Name = model.Name;
            user.Email = model.Email;
            user.UserName = model.Username;
            user.Description = model.Description;

            // Resim yükleme işlemini ayrı bir metoda taşıyın
            if (model.ImageUrl != null)
            {
                user.ImageUrl = await SaveImageAsync(model.Image);
            }

            // Yeni fotoğraf yoksa mevcut fotoğrafı koruyun veya varsayılan fotoğraf atayın
            user.ImageUrl ??= "/userImages/default.jpg";

            // Şifreyi isteğe bağlı olarak güncelleyin
            if (!string.IsNullOrEmpty(model.Password))
            {
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.Password);
            }

            // Kullanıcıyı güncelleyin
            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }

            // Hata durumunda mesaj ekleyin
            ModelState.AddModelError("", "Kullanıcı güncellenirken bir hata oluştu.");
            return View(model);
        }

        private async Task<string> SaveImageAsync(IFormFile image)
        {
            var resource = Directory.GetCurrentDirectory();
            var extension = Path.GetExtension(image.FileName);
            var imageName = Guid.NewGuid() + extension;
            var saveLocation = Path.Combine(resource, "wwwroot/userImages", imageName);

            using (var stream = new FileStream(saveLocation, FileMode.Create))
            {
                await image.CopyToAsync(stream);
            }

            return "/userImages/" + imageName;
        }


    }
}
