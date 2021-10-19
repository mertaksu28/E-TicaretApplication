using Core.Utilities.Results.Abstract;
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
        IDataResult<List<Basket>> GetAll();
        IDataResult<Basket> GetById(int id);
        IResult Add(Basket basket);
        IResult Delete(Basket basket);
        IResult Update(Basket basket);
    }
}
