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
        List<Article> LastTake5ListArticlesWithCategory();
        Article GetArticleByIdWithTagCloudAndAppUser(int id);

        List<Article> GetArticleListByAppUserId(int id);
    }
}
