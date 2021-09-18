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
    public class AddressManager : IAddressService
    {

        EfAddressRepository _efAddressRepository;

        public AddressManager()
        {
            _efAddressRepository = new EfAddressRepository();
        }

        public void Add(Address address)
        {
            _efAddressRepository.Add(address);
        }

        public void Delete(Address address)
        {
            _efAddressRepository.Delete(address);
        }

        public List<Address> GetAll()
        {
            return _efAddressRepository.GetAll();
        }

        public Address GetById(int id)
        {
            return _efAddressRepository.GetById(id);
        }

        public void Update(Address address)
        {
            _efAddressRepository.Update(address);
        }
    }
}
