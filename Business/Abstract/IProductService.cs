using Entity.Concrete;
using Entity.DTOs;
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
        List<ProductDetailDto> GetProductDetails();
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
    }
}
