using Multishop.DataAccess.Abstract;
using MultiShop.Entities.Concrete;
using MultiShop.Entities.DTOs.CategoryDTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiShop.Core.DataAccess.EntityFramework;

namespace Multishop.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfRepositoryBase<Category, AppDbContext>, ICategoryDal
    {
        public async Task<bool> AddCategory(CategoryAddDTO categoryAddDTO)
        {
            try
            {
                using var context = new AppDbContext();
                var category = new Category()
                {
                    PhotoUrl = categoryAddDTO.PhotoUrl,
                    isFeatured = false
                };
 
                await context.Categories.AddAsync(category);
                await context.SaveChangesAsync();

                for (int i=0;i<categoryAddDTO.CategoryName.Count;i++)
                {
                    CategoryLanguage cl = new()
                    {
                        CategoryName = categoryAddDTO.CategoryName[i],
                        Langcode = categoryAddDTO.LangCode[i],
                        CategoryId = category.Id,
                        SeoUrl="wefg"
                    };
                    await context.CategoryLanguages.AddAsync(cl);
                    await context.SaveChangesAsync();

                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<CategoryHomeListDTO> GetCategoriesByLanguage(string langcode)
        {
            using var context = new AppDbContext();
            var result = context.CategoryLanguages
                .Include(z => z.Category)
                .Where(x => x.Langcode == langcode)
                .Select(x => new CategoryHomeListDTO
                {
                    Id = x.Category.Id,
                    CategoryName = x.CategoryName,
                    SeoUrl = x.SeoUrl,
                    PhotoUrl = x.Category.PhotoUrl,
                    ProductCount = 0
                })
                .ToList();
            return result;
        }
    }
}
