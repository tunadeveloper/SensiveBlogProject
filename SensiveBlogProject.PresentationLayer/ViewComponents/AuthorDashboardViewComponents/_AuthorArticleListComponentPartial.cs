using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SensiveBlogProject.BusinessLayer.Abstract;
using SensiveBlogProject.EntityLayer.Concrete;

namespace BlogProject.PresentationLayer.ViewComponents.AuthorDashboardViewComponents
{
    public class _AuthorArticleListComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleService;
        private readonly UserManager<AppUser> _userManager;

        public _AuthorArticleListComponentPartial(IArticleService articleService, UserManager<AppUser> userManager)
        {
            _articleService = articleService;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);

            if (user != null)
            {
                // Kullanıcının makalelerini alın
                var articles = _articleService.TGetArticleListByAppUserId(user.Id);

                return View(articles); // Makaleleri View'e gönder
            }

            return View(new List<Article>()); // Kullanıcı yoksa boş liste gönder
        }
    }
}
