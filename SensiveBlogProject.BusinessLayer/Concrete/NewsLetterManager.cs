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
    public class NewsLetterManager :INewsLetterService
    {
        private readonly INewsLetterDal _NewsLetterDal;

        public NewsLetterManager(INewsLetterDal NewsLetterDal)
        {
            _NewsLetterDal = NewsLetterDal;
        }

        public void TDelete(int id)
        {
            _NewsLetterDal.Delete(id);
        }

        public List<NewsLetter> TGetAll()
        {
            return _NewsLetterDal.GetAll();
        }

        public NewsLetter TGetById(int id)
        {
            return _NewsLetterDal.GetById(id);
        }

        public void TInsert(NewsLetter entity)
        {
            _NewsLetterDal.Insert(entity);

        }

        public void TUpdate(NewsLetter entity)
        {
            _NewsLetterDal.Update(entity);
        }
    }
}
