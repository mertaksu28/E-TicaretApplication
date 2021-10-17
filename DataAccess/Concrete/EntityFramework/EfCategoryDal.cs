using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Conctrete.EntityFramework;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, ETicaretContext>, ICategoryDal
    {
        public List<CategoryDetailDto> GetCategorDetails()
        {
            using (ETicaretContext context = new ETicaretContext())
            {
                var result = from c in context.Categories
                             join b in context.Brands
                             on c.CategoryId equals b.BrandId
                             select new CategoryDetailDto
                             {
                                 CategoryName = c.CategoryName,
                                 BrandName = b.BrandName
                             };
                return result.ToList();
            }
        }
    }
}
