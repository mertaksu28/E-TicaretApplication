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
    public class CityManager : ICityService
    {

        EfCityRepository _efCityRepository;

        public CityManager()
        {
            _efCityRepository = new EfCityRepository();
        }

        public void Add(City city)
        {
            _efCityRepository.Add(city);
        }

        public void Delete(City city)
        {
            _efCityRepository.Delete(city);
        }

        public List<City> GetAll()
        {
            return _efCityRepository.GetAll();
        }

        public City GetById(int id)
        {
            return _efCityRepository.GetById(id);
        }

        public void Update(City city)
        {
            _efCityRepository.Update(city);
        }
    }
}
