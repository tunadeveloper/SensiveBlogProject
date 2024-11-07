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
            var context = new SensiveContext();
            var values = context.Articles.Include(x => x.Category).ToList();
            return values;
        }

        public List<Article> ArticleListWithCategoryAndAppUser()
        {
            var context = new SensiveContext();
            var values = context.Articles.Include(y=>y.Category).Include(x=>x.AppUser).ToList();
            return values;
        }
    }
}
