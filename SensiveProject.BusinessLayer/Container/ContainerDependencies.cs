using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using SensiveProject.BusinessLayer.Abstract;
using SensiveProject.BusinessLayer.Concrete;
using SensiveProject.DataAccessLayer.Abstract;
using SensiveProject.DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace SensiveProject.BusinessLayer.Container
{
	public static class Extensions
	{
		public static void ContainerDependencies(this IServiceCollection services)
		{
			services.AddLocalization(options => options.ResourcesPath = "Resources");
			services.AddMvc().AddFluentValidation();

			services.AddScoped<ICategoryDal,EfCategoryDal>();
			services.AddScoped<ICategoryService,CategoryManager>();

			services.AddScoped<IArticleDal, EfArticleDal>();
			services.AddScoped<IArticleService, ArticleManager>();

			services.AddScoped<ICommentDal, EfCommentDal>();
			services.AddScoped<ICommentService, CommentManager>();

			services.AddScoped<IContactDal, EfContactDal>();
			services.AddScoped<IContactService, ContactManager>();

			services.AddScoped<IContactInfoDal, EfContactInfoDal>();
			services.AddScoped<IContactInfoService, ContactInfoManager>();

			services.AddScoped<INewsletterDal, EfNewsletterDal>();
			services.AddScoped<INewsletterService, NewsletterManager>();

			services.AddScoped<ITagCloudDal, EfTagCloudDal>();
			services.AddScoped<ITagCloudService, TagCloudManager>();

			services.AddScoped<IAppUserDal, EfAppUserDal>();
			services.AddScoped<IAppUserService, AppUserManager>();

			services.AddScoped<IArticleTagCloudDal, EfArticleTagCloudDal>();
			services.AddScoped<IArticleTagCloudService, ArticleTagCloudManager>();

		}
	}
}