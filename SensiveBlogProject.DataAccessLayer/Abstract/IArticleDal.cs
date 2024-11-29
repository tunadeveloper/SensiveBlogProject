using SensiveBlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveBlogProject.DataAccessLayer.Abstract
{
    public interface IArticleDal :IGenericDal<Article>
    {
        List<Article> ArticleListWithCategory();
        List<Article> ArticleListWithCategoryAndAppUser();

        Article GetLastArticle();

        List<Article> GetArticlesByAppUserID(int id);
    }
}
