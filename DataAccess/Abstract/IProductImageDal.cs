using Core.DataAccess;
using Core.Utilities.Results.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductImageDal : IEntityRepository<ProductImage>
    {
    }
}
