using ElnurJUAN.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElnurJUAN.Areas.Manage.Controllers
{
    [Area("manage")]
    [Authorize(Roles = "SuperAdmin,Admin")]
    public class CategoryController : Controller
    {
        private readonly JuanContext _context;
        private readonly IWebHostEnvironment _env;

        public CategoryController(JuanContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        //INDEX ACTION
        public IActionResult Index(string filter, int page = 1)
        {
            ViewBag.Filter = filter;

            var categories = _context.Categories.Include(x => x.Shoes).AsQueryable();

            if (filter != null)
                categories = categories.Where(x => x.IsDeleted == (filter == "true" ? true : false));

            string pageSizeStr = _context.Settings.FirstOrDefault(x => x.Key == "PageSize").Value;
            int pageSize = pageSizeStr == null ? 3 : int.Parse(pageSizeStr);
            return View(PagenatedList<Category>.Create(categories, page, pageSize));

        }

        //CREATE ACTION
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            category.CreatedAt = DateTime.UtcNow.AddHours(4);
            _context.Categories.Add(category);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        //EDIT ACTION
        public IActionResult Edit(int id)
        {
            Category category = _context.Categories.FirstOrDefault(x => x.Id == id && !x.IsDeleted);

            if (category == null) return NotFound();

            return View(category);
        }
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (!ModelState.IsValid)
                return View();

            Category existCategory= _context.Categories.FirstOrDefault(x => x.Id == category.Id && !x.IsDeleted);
            if (existCategory == null) return NotFound();


            existCategory.Name = category.Name;
            existCategory.LastUpdateDate = DateTime.UtcNow.AddHours(4);

            _context.SaveChanges();
            return RedirectToAction("index");
        }

        //DELETE ACTION
        public IActionResult Delete(int id)
        {
            Category existCategory = _context.Categories.FirstOrDefault(x => x.Id == id && !x.IsDeleted);

            if (existCategory == null)
                return NotFound();

            existCategory.IsDeleted = true;
            _context.SaveChanges();

            return RedirectToAction("index");
        }
        //RESTORE ACTION
        public IActionResult Restore(int id)
        {
            Category existCategory = _context.Categories.FirstOrDefault(x => x.Id == id && x.IsDeleted);

            if (existCategory == null)
                return NotFound();

            existCategory.IsDeleted = false;
            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
