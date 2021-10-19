using Core.Utilities.Results.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;


namespace Business.Abstract
{
    public interface IAddressService
    {
        IDataResult<List<Address>> GetAll();
        IDataResult<Address> GetById(int id);
        IResult Add(Address address);
        IResult Delete(Address address);
        IResult Update(Address address);
    }
}
