using MultiShop.Core.DataAccess;
using MultiShop.Core.DataAccess.EntityFramework;
using MultiShop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multishop.DataAccess.Abstract
{
    public interface ICategoryDal:IRepositoryBase<Category>
    {

    }
}
