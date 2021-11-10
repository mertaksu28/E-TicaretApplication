using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
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
    public class AddressManager : IAddressService
    {

        IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        [ValidationAspect(typeof(AddressValidator))]
        public IResult Add(Address address)
        {
            _addressDal.Add(address);
            return new SuccessResult();
        }

        public IResult Delete(Address address)
        {
            _addressDal.Delete(address);
            return new SuccessResult();
        }

        public IDataResult<List<Address>> GetAll()
        {
            return new SuccessDataResult<List<Address>>(_addressDal.GetAll());
        }

        public IDataResult<Address> GetById(int id)
        {
            return new SuccessDataResult<Address>(_addressDal.Get(a => a.AdressId == id));
        }

        public IResult Update(Address address)
        {
            _addressDal.Update(address);
            return new SuccessResult();
        }
    }
}
