using Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class ProductImage : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }
    }
}
