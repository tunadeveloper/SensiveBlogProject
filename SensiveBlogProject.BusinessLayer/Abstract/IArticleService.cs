using SensiveBlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveBlogProject.BusinessLayer.Abstract
{
    public interface IArticleService :IGenericService<Article>
    {
        List<Article> TArticleListWithCategory();
        List<Article> TArticleListWithCategoryAndAppUser();
        public Article TGetLastArticle();
    }
}
