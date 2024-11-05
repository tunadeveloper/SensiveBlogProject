﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveBlogProject.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        List<T> GetAll();   
        T GetById(int id);

        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
