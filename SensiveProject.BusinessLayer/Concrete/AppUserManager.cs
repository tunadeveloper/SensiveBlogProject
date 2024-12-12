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
	public class AppUserManager : IAppUserService
	{
		private readonly IAppUserDal _appUserDal;

		public AppUserManager(IAppUserDal appUserDal)
		{
			_appUserDal = appUserDal;
		}

		public void TDelete(int id)
		{
			throw new NotImplementedException();
		}

		public List<AppUser> TGetAll()
		{
			return _appUserDal.GetAll();
		}

		public AppUser TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public void TInsert(AppUser entity)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(AppUser entity)
		{
			throw new NotImplementedException();
		}
	}
}
