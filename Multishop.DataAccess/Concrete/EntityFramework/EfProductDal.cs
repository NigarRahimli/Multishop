using Multishop.DataAccess.Abstract;
using MultiShop.Core.DataAccess.EntityFramework;
using MultiShop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multishop.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfRepositoryBase<Product,AppDbContext>,IProductDal
    {
    }
}
