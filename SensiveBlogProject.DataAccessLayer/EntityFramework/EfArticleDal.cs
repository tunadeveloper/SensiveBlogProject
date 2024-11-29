using Microsoft.EntityFrameworkCore;
using SensiveBlogProject.DataAccessLayer.Abstract;
using SensiveBlogProject.DataAccessLayer.Context;
using SensiveBlogProject.DataAccessLayer.Repositories;
using SensiveBlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveBlogProject.DataAccessLayer.EntityFramework
{
    public class EfArticleDal : GenericRepository<Article>, IArticleDal
    {
        public EfArticleDal(SensiveContext context) : base(context)
        {
        }

        public List<Article> ArticleListWithCategory()
        {
            using (var context = new SensiveContext())
            {
                return context.Articles.Include(x => x.Category).ToList();
            }
        }

        public List<Article> ArticleListWithCategoryAndAppUser()
        {
            using (var context = new SensiveContext())
            {
                return context.Articles.Include(x => x.Category).Include(y=>y.AppUser).ToList();
            }
        }

        public List<Article> GetArticlesByAppUserID(int id)
        {
            using (var context = new SensiveContext())
            {
                return context.Articles.Where(x=>x.AppUserId ==id).ToList();
            }
        }

        public Article GetLastArticle()
        {
            using (var context = new SensiveContext())
            {
                return context.Articles.OrderByDescending(x => x.ArticleId).FirstOrDefault();
            }
        }
    }
}
