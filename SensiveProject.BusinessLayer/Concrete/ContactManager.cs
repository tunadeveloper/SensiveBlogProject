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
	public class ContactManager : IContactService
	{
		private readonly IContactDal _contactDal;

		public ContactManager(IContactDal contactDal)
		{
			_contactDal = contactDal;
		}

		public void TDelete(int id)
		{
			throw new NotImplementedException();
		}

		public List<Contact> TGetAll()
		{
			throw new NotImplementedException();
		}

		public Contact TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public void TInsert(Contact entity)
		{
			_contactDal.Insert(entity);
		}

		public void TUpdate(Contact entity)
		{
			throw new NotImplementedException();
		}
	}
}
