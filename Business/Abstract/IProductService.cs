using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
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
        IDataResult<List<Product>> GetAll();
        IDataResult<Product> GetById(int id); 
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IResult Add(Product product);
        IResult Delete(Product product);
        IResult Update(Product product);
    }
}
