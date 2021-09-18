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
    public class UserManager : IUserService
    {

        EfUserRepository _efUserRepository;

        public UserManager()
        {
            _efUserRepository = new EfUserRepository();
        }

        public void Add(User user)
        {
            _efUserRepository.Add(user);
        }

        public void Delete(User user)
        {
            _efUserRepository.Delete(user);
        }

        public List<User> GetAll()
        {
            return _efUserRepository.GetAll();
        }

        public User GetById(int id)
        {
            return _efUserRepository.GetById(id);
        }

        public void Update(User user)
        {
            _efUserRepository.Update(user);
        }
    }
}
