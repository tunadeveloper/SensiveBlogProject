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
    public class ContactManager :IContactService
    {
        private readonly IContactDal _ContactDal;

        public ContactManager(IContactDal ContactDal)
        {
            _ContactDal = ContactDal;
        }

        public void TDelete(int id)
        {
            _ContactDal.Delete(id);
        }

        public List<Contact> TGetAll()
        {
            return _ContactDal.GetAll();
        }

        public Contact TGetById(int id)
        {
            return _ContactDal.GetById(id);
        }

        public void TInsert(Contact entity)
        {
            _ContactDal.Insert(entity);

        }

        public void TUpdate(Contact entity)
        {
            _ContactDal.Update(entity);
        }
    }
}
