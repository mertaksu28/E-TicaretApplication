using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Brand : IEntity
    {
        [Key]
        public int BrandId { get; set; }
        public int ProductId { get; set; }
        public string BrandName { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }
    }
}
