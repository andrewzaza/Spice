using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Spice.Data;
using Spice.Models;
using Spice.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spice.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubCategoriesController : Controller
    {
        private readonly ApplicationDbContext db;
        [TempData]
        public string StatusMessage { get; set; }


        public SubCategoriesController(ApplicationDbContext db)
        {
            this.db = db;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var subCategories = await db.SubCategories.Include(m => m.Category).ToListAsync();
            return View(subCategories);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            SubCategoryAndCategoryViewModel model = new SubCategoryAndCategoryViewModel()
            {
                CategoriesList = await db.Categories.ToListAsync(),
                SubCategory = new Models.SubCategory()
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SubCategoryAndCategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var doesExistSubCatgory = await db.SubCategories.Include(m => m.Category)
                    .Where(m => m.Category.Id == model.SubCategory.CategoryId
                    && m.Name == model.SubCategory.Name).ToListAsync();

                if (doesExistSubCatgory.Count() > 0)
                {
                    StatusMessage = "Error: This is Sub Category Exists under "
                        + doesExistSubCatgory.FirstOrDefault()
                        .Category.Name + " Category";

                }
                else
                {
                    db.SubCategories.Add(model.SubCategory);
                    await db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }

            }

            SubCategoryAndCategoryViewModel modelv = new SubCategoryAndCategoryViewModel()
            {
                CategoriesList = await db.Categories.ToListAsync(),
                SubCategory = model.SubCategory,
                StatusMessage = StatusMessage

            };
            return View(modelv);
        }
        public async Task<IActionResult> GetSubCategories(int id)
        {
            List<SubCategory> subCategories = new List<SubCategory>();
            subCategories = await db.SubCategories.Where(m => m.CategoryId == id).ToListAsync();

            return Json(new SelectList(subCategories, "ID", "Name"));
        }
    }
}
