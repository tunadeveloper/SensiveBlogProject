using SensiveBlogProject.BusinessLayer.Abstract;
using SensiveBlogProject.BusinessLayer.Concrete;
using SensiveBlogProject.DataAccessLayer.Abstract;
using SensiveBlogProject.DataAccessLayer.Context;
using SensiveBlogProject.DataAccessLayer.EntityFramework;
using SensiveBlogProject.EntityLayer.Concrete;
using SensiveBlogProject.PresentationLayer.Models;

namespace SensiveBlogProject.PresentationLayer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<SensiveContext>();
            builder.Services.AddIdentity<AppUser,AppRole>().AddEntityFrameworkStores<SensiveContext>().AddErrorDescriber<CustomIdentityValidator>();
            // Add services to the container.

            builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
            builder.Services.AddScoped<ICategoryService, CategoryManager>();

			builder.Services.AddScoped<IArticleDal,EfArticleDal>();
			builder.Services.AddScoped<IArticleService, ArticleManager>();

			builder.Services.AddScoped<ICommentDal, EfCommentDal>();
			builder.Services.AddScoped<ICommentService, CommentManager>();

			builder.Services.AddScoped<IContactDal, EfContactDal>();
			builder.Services.AddScoped<IContactService, ContactManager>();

            builder.Services.AddScoped<IAppUserDal, EfAppUserDal>();
            builder.Services.AddScoped<IAppUserService, AppUserManager>();


			builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}