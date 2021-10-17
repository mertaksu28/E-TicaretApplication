using DataAccess.Abstract;
using DataAccess.Conctrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAddressDal : IAddressDal
    {
        public void Add(Address entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Address entity)
        {
            throw new NotImplementedException();
        }

        public Address Get(Expression<Func<Address, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Address> GetAll(Expression<Func<Address, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Address entity)
        {
            throw new NotImplementedException();
        }
    }
}
