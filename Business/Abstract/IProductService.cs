using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        List<Product> GetAllByCategoryId(int id);
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
    }
}
