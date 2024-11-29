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
    public class TagCloudManager :ITagCloudService
    {
        private readonly ITagCloudDal _TagCloudDal;

        public TagCloudManager(ITagCloudDal TagCloudDal)
        {
            _TagCloudDal = TagCloudDal;
        }

        public void TDelete(int id)
        {
            _TagCloudDal.Delete(id);
        }

        public List<TagCloud> TGetAll()
        {
            return _TagCloudDal.GetAll();
        }

        public TagCloud TGetById(int id)
        {
            return _TagCloudDal.GetById(id);
        }

        public void TInsert(TagCloud entity)
        {
            _TagCloudDal.Insert(entity);

        }

        public void TUpdate(TagCloud entity)
        {
            _TagCloudDal.Update(entity);
        }
    }
}
