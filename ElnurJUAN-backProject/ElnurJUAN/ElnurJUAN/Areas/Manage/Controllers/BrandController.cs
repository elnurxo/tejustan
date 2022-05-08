using ElnurJUAN.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ElnurJUAN.Areas.Manage.Controllers
{
    [Area("manage")]
    [Authorize(Roles = "SuperAdmin,Admin")]
    public class BrandController : Controller
    {
        private readonly JuanContext _context;
        private readonly IWebHostEnvironment _env;

        public BrandController(JuanContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        //INDEX ACTION
        public IActionResult Index(string filter, int page = 1)
        {
            ViewBag.Filter = filter;

            var brands = _context.Brands.Include(x => x.Shoes).AsQueryable();

            if (filter != null)
                brands = brands.Where(x => x.IsDeleted == (filter == "true" ? true : false));

            string pageSizeStr = _context.Settings.FirstOrDefault(x => x.Key == "PageSize").Value;
            int pageSize = pageSizeStr == null ? 3 : int.Parse(pageSizeStr);
            return View(PagenatedList<Brand>.Create(brands, page, pageSize));

        }

        //CREATE ACTION
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Brand brand)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            brand.CreatedAt = DateTime.UtcNow.AddHours(4);
            _context.Brands.Add(brand);
            _context.SaveChanges();

            return RedirectToAction("index");
        }
        //EDIT ACTION
        public IActionResult Edit(int id)
        {
            Brand author = _context.Brands.FirstOrDefault(x => x.Id == id && !x.IsDeleted);

            if (author == null) return NotFound();

            return View(author);
        }
        [HttpPost]
        public IActionResult Edit(Brand brand)
        {
            if (!ModelState.IsValid)
                return View();

            Brand existBrand = _context.Brands.FirstOrDefault(x => x.Id == brand.Id && !x.IsDeleted);
            if (existBrand == null) return NotFound();


            existBrand.Name = brand.Name;
            existBrand.LastUpdateDate = DateTime.UtcNow.AddHours(4);

            _context.SaveChanges();
            return RedirectToAction("index");
        }
        //DELETE ACTION
        public IActionResult Delete(int id)
        {
            Brand existBrand = _context.Brands.FirstOrDefault(x => x.Id == id && !x.IsDeleted);

            if (existBrand == null)
                return NotFound();

            existBrand.IsDeleted = true;
            _context.SaveChanges();

            return RedirectToAction("index");
        }
        //RESTORE ACTION
        public IActionResult Restore(int id)
        {
            Brand existBrand = _context.Brands.FirstOrDefault(x => x.Id == id && x.IsDeleted);

            if (existBrand == null)
                return NotFound();

            existBrand.IsDeleted = false;
            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
