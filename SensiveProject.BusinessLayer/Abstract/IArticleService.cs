using SensiveProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveProject.BusinessLayer.Abstract
{
	public interface IArticleService : IGenericService<Article>
	{
        List<Article> TArticleListWithCategory();
        List<Article> TArticleListWithCategoryAndAppUser();
		public Article TGetLastArticle();
		List<Article> TGetArticlesByAppUserId(int id);
		public Article TGetByIdWithCategory(int id);
	}
}
