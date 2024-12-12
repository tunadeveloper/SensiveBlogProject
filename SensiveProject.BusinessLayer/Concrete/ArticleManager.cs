using SensiveProject.BusinessLayer.Abstract;
using SensiveProject.DataAccessLayer.Abstract;
using SensiveProject.DataAccessLayer.Context;
using SensiveProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveProject.BusinessLayer.Concrete
{
	public class ArticleManager : IArticleService
	{
		private readonly IArticleDal _articleDal;

		public ArticleManager(IArticleDal articleDal)
		{
			_articleDal = articleDal;
		}

        public List<Article> TArticleListWithCategory()
        {
           return _articleDal.ArticleListWithCategory();
        }

        public List<Article> TArticleListWithCategoryAndAppUser()
        {
            return _articleDal.ArticleListWithCategoryAndAppUser();
        }

        public void TDelete(int id)
		{
			_articleDal.Delete(id);
		}

		public List<Article> TGetAll()
		{
			return _articleDal.GetAll();
		}

		public List<Article> TGetArticlesByAppUserId(int id)
		{
			return _articleDal.GetArticlesByAppUserId(id);
		}

		public Article TGetById(int id)
		{
			return _articleDal.GetById(id);
		}

		public Article TGetByIdWithCategory(int id)
		{
			return _articleDal.GetByIdWithCategory(id);
		}

		public Article TGetLastArticle()
		{
			return _articleDal.GetLastArticle();
		}

		public void TInsert(Article entity)
		{
			_articleDal.Insert(entity);
		}

		public void TUpdate(Article entity)
		{
			if (entity.Description != "" && entity.Title.Length >= 5 && entity.Title.Length <= 100)
			{
				_articleDal.Update(entity);
			}
			else
			{
				//hata mesajı
			}
		}
	}
}
