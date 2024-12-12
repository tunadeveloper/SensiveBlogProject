using SensiveProject.DataAccessLayer.Abstract;
using SensiveProject.DataAccessLayer.Context;
using SensiveProject.DataAccessLayer.Repositories;
using SensiveProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveProject.DataAccessLayer.EntityFramework
{
	public class EfAppUserDal : GenericRepository<AppUser>, IAppUserDal
	{
		public EfAppUserDal(SensiveContext context) : base(context)
		{
		}
	}
}
