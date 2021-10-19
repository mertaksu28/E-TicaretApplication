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
    public class BasketManager : IBasketService
    {
        IBasketDal _basketDal;

        public BasketManager(IBasketDal basketDal)
        {
            _basketDal = basketDal;
        }

        public IResult Add(Basket basket)
        {
            _basketDal.Add(basket);
            return new SuccessResult();
        }

        public IResult Delete(Basket basket)
        {
            _basketDal.Delete(basket);
            return new SuccessResult();
        }

        public IDataResult<List<Basket>> GetAll()
        {
            return new SuccessDataResult<List<Basket>>(_basketDal.GetAll());
        }

        public IDataResult<Basket> GetById(int id)
        {
            return new SuccessDataResult<Basket>(_basketDal.Get(b => b.BasketId == id));
        }

        public IResult Update(Basket basket)
        {
            _basketDal.Update(basket);
            return new SuccessResult();
        }
    }
}
