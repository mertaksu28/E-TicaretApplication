using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int id);
        List<CategoryDetailDto> GetCategoryDetails();
        void Add(Category category);
        void Delete(Category category);
        void Update(Category category);
    }
}
