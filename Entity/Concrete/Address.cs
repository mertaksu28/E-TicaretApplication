using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Address:IEntity
    {
        [Key]
        public int AdressId { get; set; }
        public int UserId  { get; set; }
        public int CityId { get; set; }
        public string AddressDetail { get; set; }
        public int PostalCode { get; set; }
    }
}
