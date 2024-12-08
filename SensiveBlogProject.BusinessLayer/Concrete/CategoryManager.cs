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

        public List<Category> TGetAllCategoriesWithArticle()
        {
            return _categoryDal.GetAllCategoriesWithArticle();
        }

        public Category TGetById(int id)
        {
           return _categoryDal.GetById(id);
        }

        public void TInsert(Category entity)
        {
           _categoryDal.Insert(entity);

        }

        public void TUpdate(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
