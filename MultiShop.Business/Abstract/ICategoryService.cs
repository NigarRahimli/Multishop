using MultiShop.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Business.Absract
{
    public interface ICategoryService
    {
        void AddCategory(Category category);
    }
}
