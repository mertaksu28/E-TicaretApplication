using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICityService
    {
        List<City> GetAll();
        City GetById(int id);
        void Add(City city);
        void Delete(City city);
        void Update(City city);
    }
}
