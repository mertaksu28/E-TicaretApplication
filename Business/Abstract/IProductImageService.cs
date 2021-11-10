using Core.Utilities.Results.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductImageService
    {
        IDataResult<ProductImage> GetAll();
        IDataResult<ProductImage> GetById(int id);
        IResult Add(ProductImage productImage);
        IResult Delete(ProductImage productImage);
        IResult Update(ProductImage productImage);
    }
}
