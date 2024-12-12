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
	public class ContactInfoManager : IContactInfoService
	{
		private readonly IContactInfoDal _contactInfoDal;

		public ContactInfoManager(IContactInfoDal contactInfoDal)
		{
			_contactInfoDal = contactInfoDal;
		}

		public void TDelete(int id)
		{
			throw new NotImplementedException();
		}

		public List<ContactInfo> TGetAll()
		{
			return _contactInfoDal.GetAll();
		}

		public ContactInfo TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public void TInsert(ContactInfo entity)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(ContactInfo entity)
		{
			throw new NotImplementedException();
		}
	}
}
