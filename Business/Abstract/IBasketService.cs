using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBasketService
    {
        List<Basket> GetAll();
        Basket GetById(int id);
        void Add(Basket basket);
        void Delete(Basket basket);
        void Update(Basket basket);
    }
}
