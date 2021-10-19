using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
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

        ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public IResult Add(City city)
        {
            _cityDal.Add(city);
            return new SuccessResult();
        }

        public IResult Delete(City city)
        {
            _cityDal.Delete(city);
            return new SuccessResult();
        }

        public IDataResult<List<City>> GetAll()
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetAll());
        }

        public IDataResult<City> GetById(int id)
        {
            return new SuccessDataResult<City>(_cityDal.Get(c => c.CityId == id));
        }

        public IResult Update(City city)
        {
            _cityDal.Delete(city);
            return new SuccessResult();
        }
    }
}
