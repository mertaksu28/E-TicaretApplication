using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Basket : IEntity
    {
        [Key]
        public int BasketId { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int Count { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }
    }
}
