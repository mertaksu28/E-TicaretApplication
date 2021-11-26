using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class ProductDetailDto : IDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public string BrandName { get; set; }
        public int UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
