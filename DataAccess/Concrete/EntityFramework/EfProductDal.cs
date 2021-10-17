using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Conctrete.EntityFramework;
using Entity.Concrete;
using Entity.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, ETicaretContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (ETicaretContext context = new ETicaretContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             join b in context.Brands
                             on p.BrandId equals b.BrandId
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 BrandName = b.BrandName,
                                 UnitsInStock = p.UnitsInStock
                             };
                return result.ToList();
            }
        }
    }
}
