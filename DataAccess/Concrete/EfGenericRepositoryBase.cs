using DataAccess.Abstract;
using DataAccess.Context;
using Entity.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Conctrete
{
    public class EfGenericRepositoryBase<T> : IGenericRepositoryDal<T> where T : class, IEntity, new()
    {
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            using (ETicaretContext eTicaret = new ETicaretContext())
            {
                return eTicaret.Set<T>().ToList();
            }
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
