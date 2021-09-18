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
    public class OrderManager : IOrderService
    {

        EfOrderRepository _eforderRepository;

        public OrderManager()
        {
            _eforderRepository = new EfOrderRepository();
        }

        public void Add(Order order)
        {
            _eforderRepository.Add(order);
        }

        public void Delete(Order order)
        {
            _eforderRepository.Delete(order);
        }

        public List<Order> GetAll()
        {
            return _eforderRepository.GetAll();
        }

        public Order GetById(int id)
        {
            return _eforderRepository.GetById(id);
        }

        public void Update(Order order)
        {
            _eforderRepository.Update(order);
        }
    }
}
