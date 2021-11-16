using Business.Abstract;
using Core.Utilities.FileOperations;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
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

        public IResult Add(ProductImageDto productImageDto)
        {
            ProductImage image = new ProductImage
            {
                Id = productImageDto.Id,
                ImagePath = FileOperation.FileAdd(productImageDto.ImageFileName),
                ProductId = productImageDto.ProductId,
                Date = DateTime.Now
            };
            _productImageDal.Add(image);
            return new SuccessResult();
        }

        public IResult Delete(ProductImageDto productImageDto)
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

        public IResult Update(ProductImageDto productImageDto)
        {
            throw new NotImplementedException();
        }
    }
}
