using Business.Abstract;
using Business.Constants;
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

        public IResult Delete(ProductImage productImageDto)
        {
            var result = _productImageDal.Get(pi => pi.Id == productImageDto.Id);

            if (result == null)
            {
                return new ErrorResult(Messages.ProductImageNotFound);
            }
            FileOperation.DeleteFile(result.ImagePath);

            _productImageDal.Delete(result);
            return new SuccessResult(Messages.ProductImageDeleted);
        }

        public IDataResult<List<ProductImage>> GetAll()
        {
            _productImageDal.GetAll();
            return new SuccessDataResult<List<ProductImage>>(Messages.ProductImageListed);
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
