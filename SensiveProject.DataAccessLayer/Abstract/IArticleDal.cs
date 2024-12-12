using SensiveProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveProject.DataAccessLayer.Abstract
{
    public interface IArticleDal : IGenericDal<Article>
    {
        List<Article> ArticleListWithCategory();
        List<Article> ArticleListWithCategoryAndAppUser();
        Article GetLastArticle();
        List<Article> GetArticlesByAppUserId(int id);
        public Article GetByIdWithCategory(int id);


	}
}
