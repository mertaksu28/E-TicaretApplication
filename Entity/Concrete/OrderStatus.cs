using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class OrderStatus : IEntity
    {
        public int OrderStatusId { get; set; }
        public string OrderStatusName { get; set; }
        public DateTime CreateName { get; set; }
        public bool İsActive { get; set; }
    }
}
