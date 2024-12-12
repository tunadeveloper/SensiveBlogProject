using Microsoft.EntityFrameworkCore;
using SensiveProject.DataAccessLayer.Abstract;
using SensiveProject.DataAccessLayer.Context;
using SensiveProject.DataAccessLayer.Repositories;
using SensiveProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveProject.DataAccessLayer.EntityFramework
{
    public class EfArticleDal : GenericRepository<Article>, IArticleDal
    {
        public EfArticleDal(SensiveContext context) : base(context)
        {
        }

        // Entity'e ozgu metotlar
        public List<Article> ArticleListWithCategory()
        {
            var context = new SensiveContext();
            var values=context.Articles.Include(x => x.Category).ToList();
            return values;
        }

        public List<Article> ArticleListWithCategoryAndAppUser()
        {
            var context=new SensiveContext();
            var values=context.Articles.Include(x=>x.Category).Include(y=>y.AppUser).Include(z=>z.Comments).Include(k => k.ArticleTagClouds).ThenInclude(k => k.TagCloud).ToList();
            return values;
        }

		public List<Article> GetArticlesByAppUserId(int id)
		{
			var context = new SensiveContext();
            var values=context.Articles.Where(x=>x.AppUserId==id).Include(x=>x.Category).ToList();
            return values;
		}

		public Article GetLastArticle()
		{
			var context = new SensiveContext();
            var value=context.Articles.OrderByDescending(x=>x.ArticleId).Take(1).FirstOrDefault();
            return value;
		}

        public Article GetByIdWithCategory(int id)
        {
            var context = new SensiveContext();
            var values=context.Articles.Where(x=>x.ArticleId==id).Include(x=>x.Category).FirstOrDefault();
            return values;
        }
	}
}
