using MultiShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Entities.Concrete
{
    public class User:AppUser {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

    }
}
