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
	public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
	{
		public EfCategoryDal(SensiveContext context) : base(context)
		{
		}

		public List<Category> GetCategoryWithArticle()
		{
			using var context = new SensiveContext();
			var values = context.Categories.Include(y => y.Articles).ToList();
			return values;
		}
	}
}
