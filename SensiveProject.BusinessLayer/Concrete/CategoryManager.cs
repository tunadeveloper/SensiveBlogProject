using SensiveProject.BusinessLayer.Abstract;
using SensiveProject.DataAccessLayer.Abstract;
using SensiveProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveProject.BusinessLayer.Concrete
{
	public class CategoryManager : ICategoryService
	{
		private readonly ICategoryDal _categoryDal;

		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}

		public void TDelete(int id)
		{
			_categoryDal.Delete(id);
		}

		public List<Category> TGetAll()
		{
			return _categoryDal.GetAll();
		}

		public Category TGetById(int id)
		{
			return _categoryDal.GetById(id);
		}

		public List<Category> TGetCategoryWithArticle()
		{
			return _categoryDal.GetCategoryWithArticle();
		}

		public void TInsert(Category entity)
		{
			if (entity.CategoryName.Length >= 5 && entity.CategoryName.Length <= 50)
			{
				_categoryDal.Insert(entity);
			}
			else
			{
				//hata mesajı
			}
		}

		public void TUpdate(Category entity)
		{
			_categoryDal.Update(entity);
		}
	}
}
