using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class OrderStatus : IEntity
    {
        [Key]
        public int OrderStatusId { get; set; }
        public string OrderStatusName { get; set; }
        public DateTime CreateName { get; set; }
        public bool IsActive { get; set; }
    }
}
