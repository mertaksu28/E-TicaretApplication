using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class CategoryDetailDto : IDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string BrandName { get; set; }
    }
}
