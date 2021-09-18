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
    public class BasketManager : IBasketService
    {
        EfBasketRepository _efBasketRepository;

        public BasketManager()
        {
            _efBasketRepository = new EfBasketRepository();
        }

        public void Add(Basket basket)
        {
            _efBasketRepository.Add(basket);
        }

        public void Delete(Basket basket)
        {
            _efBasketRepository.Delete(basket);
        }

        public List<Basket> GetAll()
        {
            return _efBasketRepository.GetAll();
        }

        public Basket GetById(int id)
        {
            return _efBasketRepository.GetById(id);
        }

        public void Update(Basket basket)
        {
            _efBasketRepository.Update(basket);
        }
    }
}
