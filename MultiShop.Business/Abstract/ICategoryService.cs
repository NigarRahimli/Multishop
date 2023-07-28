using MultiShop.Entities.Concrete;
using MultiShop.Entities.DTOs.CategoryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Business.Absract
{
    public interface ICategoryService
    {
        void AddCategory(CategoryAddDTO category);
        void DeleteCategory(Category category);
        void UpdateCategoy(Category category);
        List<CategoryHomeListDTO> GetCategories(string langcode);
        List<Category>GetNavbarCategories(string langcode);

    }
}
