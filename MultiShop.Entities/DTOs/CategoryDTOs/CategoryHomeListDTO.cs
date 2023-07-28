using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Entities.DTOs.CategoryDTOs
{
    public class CategoryHomeListDTO
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string SeoUrl { get; set; }
        public int ProductCount { get; set;}
        public string PhotoUrl { get; set; }
    }
}
