﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Entities.Concrete
{
    public class Category
    {
        public int Id { get; set; }
        public string PhotoUrl { get; set; }
        public bool isFeatured { get; set; }

    }
}
