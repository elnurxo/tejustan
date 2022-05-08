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
    public class ColorController : Controller
    {
        private readonly JuanContext _context;
        private readonly IWebHostEnvironment _env;

        public ColorController(JuanContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        //INDEX ACTION
        public IActionResult Index(string filter, int page = 1)
        {

            ViewBag.Filter = filter;

            var colors = _context.Colors.Include(x => x.ShoeColors).AsQueryable();

            if (filter != null)
                colors = colors.Where(x => x.IsDeleted == (filter == "true" ? true : false));

            string pageSizeStr = _context.Settings.FirstOrDefault(x => x.Key == "PageSize").Value;
            int pageSize = pageSizeStr == null ? 3 : int.Parse(pageSizeStr);
            return View(PagenatedList<Color>.Create(colors, page, pageSize));
        }

        //CREATE ACTION
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Color color)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (color.HexValue.Contains("#"))
            {
                ModelState.AddModelError("HexValue", "You can't use #");
                return View();
            }

            color.HexValue = "#" + color.HexValue;
            color.CreatedAt = DateTime.UtcNow.AddHours(4);
            _context.Colors.Add(color);
            _context.SaveChanges();


            return RedirectToAction("index");
        }
        //EDIT ACTION
        public IActionResult Edit(int id)
        {
            Color color = _context.Colors.FirstOrDefault(x => x.Id == id && !x.IsDeleted);

            if (color == null) return NotFound();

            return View(color);
        }
        [HttpPost]
        public IActionResult Edit(Color color)
        {
            if (!ModelState.IsValid)
                return View();

            Color existColor = _context.Colors.FirstOrDefault(x => x.Id == color.Id && !x.IsDeleted);
            if (existColor == null) return NotFound();


            existColor.Name = color.Name;
            existColor.LastUpdateDate = DateTime.UtcNow.AddHours(4);

            _context.SaveChanges();
            return RedirectToAction("index");
        }
        //DELETE ACTION
        public IActionResult Delete(int id)
        {
            Color existColor = _context.Colors.FirstOrDefault(x => x.Id == id && !x.IsDeleted);

            if (existColor == null)
                return NotFound();

            existColor.IsDeleted = true;
            _context.SaveChanges();

            return RedirectToAction("index");
        }
        //RESTORE ACTION
        public IActionResult Restore(int id)
        {
            Color existColor = _context.Colors.FirstOrDefault(x => x.Id == id && x.IsDeleted);

            if (existColor == null)
                return NotFound();

            existColor.IsDeleted = false;
            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
