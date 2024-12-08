using BlogProject.DataAccesLayer.Context;
using SensiveBlogProject.DataAccessLayer.Abstract;
using SensiveBlogProject.DataAccessLayer.Repositories;
using SensiveBlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveBlogProject.DataAccessLayer.EntityFramework
{
    public class EfNewsLetterDal : GenericRepository<NewsLetter>, INewsLetterDal
    {
        public EfNewsLetterDal(BlogContext context) : base(context)
        {
        }
    }
}
