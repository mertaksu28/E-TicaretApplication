using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductImageManager : IProductImageService
    {
        IProductImageDal _productImageDal;

        public ProductImageManager(IProductImageDal productImageDal)
        {
            _productImageDal = productImageDal;
        }

        public IResult Add(ProductImage productImage)
        {
           _productImageDal.Add(productImage);
            return new SuccessResult();
        }

        public IResult Delete(ProductImage productImage)
        {
            throw new NotImplementedException();
        }

        public IDataResult<ProductImage> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<ProductImage> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(ProductImage productImage)
        {
            throw new NotImplementedException();
        }
    }
}
