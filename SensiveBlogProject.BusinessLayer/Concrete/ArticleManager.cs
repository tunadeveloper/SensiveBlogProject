using SensiveBlogProject.BusinessLayer.Abstract;
using SensiveBlogProject.DataAccessLayer.Abstract;
using SensiveBlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveBlogProject.BusinessLayer.Concrete
{
    public class ArticleManager : IArticleService
    {

        private readonly IArticleDal _ArticleDal;

        public ArticleManager(IArticleDal ArticleDal)
        {
            _ArticleDal = ArticleDal;
        }

        public List<Article> TArticleListWithCategory()
        {
         return  _ArticleDal.ArticleListWithCategory();
        }

        public List<Article> TArticleListWithCategoryAndAppUser()
        {
           return _ArticleDal.ArticleListWithCategoryAndAppUser();
        }

        public void TDelete(int id)
        {
            _ArticleDal.Delete(id);
        }
        
        public List<Article> TGetAll()
        {
            return _ArticleDal.GetAll();
        }

        public List<Article> TGetArticlesByAppUserID(int id)
        {
            return _ArticleDal.GetArticlesByAppUserID(id);
        }

        public Article TGetById(int id)
        {
            return _ArticleDal.GetById(id);
        }

        public Article TGetLastArticle()
        {
            return _ArticleDal.GetLastArticle();
        }

        public List<Article> TGetRandomArticleList()
        {
           return _ArticleDal.GetRandomArticleList();
        }

        public void TInsert(Article entity)
        {
            _ArticleDal.Insert(entity);

        }

        public void TUpdate(Article entity)
        {
            _ArticleDal.Update(entity);
        }
    }
}
