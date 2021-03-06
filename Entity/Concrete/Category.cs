using Core.Entities;
using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Category : IEntity
    {
        [Key]
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string CategoryName { get; set; }
        public bool IsActive { get; set; }
    }
}
