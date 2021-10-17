using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBasketDal : IBasketDal
    {
        public void Add(Basket entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Basket entity)
        {
            throw new NotImplementedException();
        }

        public Basket Get(Expression<Func<Basket, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Basket> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Basket> GetAll(Expression<Func<Basket, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Basket GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Basket entity)
        {
            throw new NotImplementedException();
        }
    }
}
