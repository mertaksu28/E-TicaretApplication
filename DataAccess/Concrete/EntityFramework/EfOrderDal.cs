﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Conctrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, ETicaretContext>, IOrderDal
    {
        
    }
}
