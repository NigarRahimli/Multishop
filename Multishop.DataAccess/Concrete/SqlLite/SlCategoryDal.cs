using Multishop.DataAccess.Abstract;
using MultiShop.Core.DataAccess.SqlLite;
using MultiShop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multishop.DataAccess.Concrete.SqlLite
{
    public class SlCategoryDal:SlRepositoryBase<Category>,ICategoryDal
    {
    }
}
