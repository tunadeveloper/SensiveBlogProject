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
using System.Windows.Markup;

namespace SensiveProject.DataAccessLayer.EntityFramework
{
	public class EfArticleTagCloudDal : GenericRepository<ArticleTagCloud>, IArticleTagCloudDal
	{
		public EfArticleTagCloudDal(SensiveContext context) : base(context)
		{
		}

		public List<ArticleTagCloud> GetAllByArticleId(int articleId)
		{
			using var context = new SensiveContext();
			var values = context.ArticleTagClouds.Where(x => x.ArticleId == articleId).Include(x=>x.Article).Include(x=>x.TagCloud).ToList();
			return values;
		}
	}
}
