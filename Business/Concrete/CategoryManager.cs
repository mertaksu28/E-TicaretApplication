using Business.Abstract;
using DataAccess.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {

        EfCategoryRepository _efCategoryManager;

        public CategoryManager()
        {
            _efCategoryManager = new EfCategoryRepository();
        }

        public void Add(Category category)
        {
            _efCategoryManager.Add(category);
        }

        public void Delete(Category category)
        {
            _efCategoryManager.Delete(category);
        }

        public List<Category> GetAll()
        {
            return _efCategoryManager.GetAll();
        }

        public Category GetById(int id)
        {
            return _efCategoryManager.GetById(id);
        }

        public void Update(Category category)
        {
            _efCategoryManager.Update(category);
        }
    }
}
