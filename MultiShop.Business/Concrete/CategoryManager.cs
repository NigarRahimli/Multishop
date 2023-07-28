using Multishop.DataAccess.Abstract;
using MultiShop.Business.Absract;
using MultiShop.Entities.Concrete;
using MultiShop.Entities.DTOs.CategoryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }


        public void AddCategory(CategoryAddDTO category)
        {
           _categoryDal.AddCategory(category);
        }

        public void DeleteCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public List<CategoryHomeListDTO> GetCategories(string langcode)
        {
            return _categoryDal.GetCategoriesByLanguage(langcode);
        }

        public List<Category> GetNavbarCategories(string langcode)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategoy(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
