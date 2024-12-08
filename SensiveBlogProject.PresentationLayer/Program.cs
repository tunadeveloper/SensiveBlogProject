using BlogProject.PresentationLayer.Areas.Author.Models;
using FluentValidation.AspNetCore;
using SensiveBlogProject.BusinessLayer.Abstract;
using SensiveBlogProject.BusinessLayer.Concrete;
using SensiveBlogProject.BusinessLayer.Container;
using SensiveBlogProject.DataAccessLayer.Abstract;
using SensiveBlogProject.DataAccessLayer.Context;
using SensiveBlogProject.DataAccessLayer.EntityFramework;
using SensiveBlogProject.EntityLayer.Concrete;

namespace SensiveBlogProject.PresentationLayer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<SensiveContext>();

            builder.Services.AddIdentity<AppUser,AppRole>().AddErrorDescriber<CustomIdentityValidator>().AddEntityFrameworkStores<SensiveContext>();

            builder.Services.ContainerDependencies();

            builder.Services.AddControllersWithViews().AddFluentValidation();

            // Add services to the container.
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
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });

            app.Run();
        }
    }
}