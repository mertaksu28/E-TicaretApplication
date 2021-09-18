using DataAccess.Abstract;
using DataAccess.Conctrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class GenericRepository<T> : IGenericRepositoryDal<T> where T : class
    {
        ETicaretContext eTicaretContext = new ETicaretContext();

        public void Add(T entity)
        {
            eTicaretContext.Add(entity);
            eTicaretContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            eTicaretContext.Remove(entity);
            eTicaretContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return eTicaretContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return eTicaretContext.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            eTicaretContext.Update(entity);
            eTicaretContext.SaveChanges();
        }
    }

}
