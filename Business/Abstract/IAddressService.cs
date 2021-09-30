using Entity.Concrete;
using System;
using System.Collections.Generic;


namespace Business.Abstract
{
    public interface IAddressService
    {
        List<Address> GetAll();
        Address GetById(int id);
        void Add(Address address);
        void Delete(Address address);
        void Update(Address address);
    }
}
