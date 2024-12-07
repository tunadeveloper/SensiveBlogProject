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
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public EfCommentDal(SensiveContext context) : base(context)
        {
        }

        public List<Comment> GetArticlesByAppUserID(int id)
        {
            using (var context = new SensiveContext())
            {
                return context.Comments.Where(x=>x.AppUserId == id).ToList();
            }
        }

        public List<Comment> GetCommentByArticleID(int id)
        {
           var context = new SensiveContext();  
            var values = context.Comments.Where(x=>x.ArticleId == id).Include(y=>y.AppUser).Include(z=>z.Article).ToList();
            return values;
        }
    }
}
