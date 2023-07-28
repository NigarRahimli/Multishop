using Microsoft.AspNetCore.Mvc;
using MultiShop.Business.Absract;
using MultiShop.Entities.DTOs.CategoryDTOs;

namespace MultiShop.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var categories = _categoryService.GetCategories("Az");
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CategoryAddDTO category)
        {
            _categoryService.AddCategory(category);
            return RedirectToAction("Index");

        }
    }
}
