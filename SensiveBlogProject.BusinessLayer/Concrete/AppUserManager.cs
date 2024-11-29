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
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDal _AppUserDal;

        public AppUserManager(IAppUserDal AppUserDal)
        {
            _AppUserDal = AppUserDal;
        }

        public void TDelete(int id)
        {
            _AppUserDal.Delete(id);
        }

        public List<AppUser> TGetAll()
        {
            return _AppUserDal.GetAll();
        }

        public AppUser TGetById(int id)
        {
            return _AppUserDal.GetById(id);
        }

        public void TInsert(AppUser entity)
        {
            _AppUserDal.Insert(entity);

        }

        public void TUpdate(AppUser entity)
        {
            _AppUserDal.Update(entity);
        }
    }
}
