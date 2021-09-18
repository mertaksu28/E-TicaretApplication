using Business.Abstract;
using DataAccess.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {

        EfProductRepository _efProductRepository;

        public ProductManager()
        {
            _efProductRepository = new EfProductRepository();
        }

        public void Add(Product product)
        {
            _efProductRepository.Add(product);
        }

        public void Delete(Product product)
        {
            _efProductRepository.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _efProductRepository.GetAll();
        }

        public Product GetById(int id)
        {
            return _efProductRepository.GetById(id);
        }

        public void Update(Product product)
        {
            _efProductRepository.Update(product);
        }
    }
}
