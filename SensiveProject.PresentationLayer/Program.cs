using FluentValidation.AspNetCore;
using SensiveProject.BusinessLayer.Container;
using SensiveProject.BusinessLayer.ValidationRules;
using SensiveProject.DataAccessLayer.Context;
using SensiveProject.EntityLayer.Concrete;
using SensiveProject.PresentationLayer.Models;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Generic Repository yi kullanabilmek i�in

builder.Services.AddDbContext<SensiveContext>();

// Add services to the container.
// Identity k�t�phanesini kullanmam�za izin verir. DI kullanaca��m�z� bildirdik.

builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<SensiveContext>().AddErrorDescriber<CustomIdentityValidator>();


builder.Services.AddControllersWithViews().AddFluentValidation();
builder.Services.ContainerDependencies();


builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
// FluentValidation i�in localization deste�i ekleyin
builder.Services.AddFluentValidation(fv => fv.LocalizationEnabled = true);

builder.Services.AddControllersWithViews().AddDataAnnotationsLocalization()
		.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CreateArticleValidator>()); ;

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();

	builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication(); //Login icin
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

var supportedCultures = new[] { new CultureInfo("tr-TR"), new CultureInfo("en-US") };
// Yerelle�tirme middleware'ini ekleyin
app.UseRequestLocalization(options =>
{
	var supportedCultures = new[] { "tr", "en" };
	options.AddSupportedCultures(supportedCultures)
		   .AddSupportedUICultures(supportedCultures)
		   .SetDefaultCulture("tr"); // T�rk�e olarak ayarlad�k
});

app.MapControllers();

app.Run();
