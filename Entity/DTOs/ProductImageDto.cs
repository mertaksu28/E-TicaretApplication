using Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class ProductImageDto : IDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public IFormFile ImageFileName { get; set; }
    }
}
