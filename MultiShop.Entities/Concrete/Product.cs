using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Entities.Concrete
{
    public class Product
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal Raiting { get; set; }
        public int View { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
