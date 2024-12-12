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
	public class EfContactInfoDal : GenericRepository<ContactInfo>, IContactInfoDal
	{
		public EfContactInfoDal(SensiveContext context) : base(context)
		{
		}
	}
}
