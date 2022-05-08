using ElnurJUAN.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ElnurJUAN.Areas.Manage.Controllers
{
       [Area("manage")]
    [Authorize(Roles = "SuperAdmin,Admin")]
    public class SliderController : Controller
    {
        private readonly JuanContext _context;
        private readonly IWebHostEnvironment _env;

        public SliderController(JuanContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        //INDEX ACTION
        public IActionResult Index(int page = 1)
        {
            string pageSizeStr = _context.Settings.FirstOrDefault(x => x.Key == "PageSize").Value;
            int pageSize = string.IsNullOrWhiteSpace(pageSizeStr) ? 3 : int.Parse(pageSizeStr);
            return View(PagenatedList<Slider>.Create(_context.Sliders.AsQueryable(), page, pageSize));
        }
        //CREATE ACTION
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Slider slider)
        {
            if (slider.ImageFile == null)
                ModelState.AddModelError("ImageFile", "Image file is required!");

            if (!ModelState.IsValid)
                return View();

            if (slider.Order < 0)
            {
                ModelState.AddModelError("Order", "Order cannot be negative");
                return View();
            }

            if (slider.ImageFile.ContentType != "image/jpeg" && slider.ImageFile.ContentType != "image/png")
            {
                ModelState.AddModelError("ImageFile", "File type must be jpeg or png");
                return View();
            }

            if (slider.ImageFile.Length > 4194304)
            {
                ModelState.AddModelError("ImageFile", "file size must be less than 4mb");
                return View();
            }

            string fileName = slider.ImageFile.FileName;

            if (fileName.Length>64)
            {
                fileName = fileName.Substring(slider.ImageFile.FileName.Length - 64, 64);
            }

            slider.Image = (Guid.NewGuid().ToString() + (fileName));

            string path = Path.Combine(_env.WebRootPath, "uploads/sliders", slider.Image);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                slider.ImageFile.CopyTo(stream);
            }

            slider.CreatedAt = DateTime.UtcNow.AddHours(4);
            _context.Sliders.Add(slider);
            _context.SaveChanges();

            return RedirectToAction("index");
        }
        //EDIT ACTION
        public IActionResult Edit(int id)
        {
            Slider slider = _context.Sliders.FirstOrDefault(x => x.Id == id && !x.IsDeleted);

            if (slider == null) return NotFound();

            return View(slider);
        }

        [HttpPost]
        public IActionResult Edit(Slider slider)
        {
            if (!ModelState.IsValid)
                return View();

            Slider existSlider = _context.Sliders.FirstOrDefault(x => x.Id == slider.Id && !x.IsDeleted);
            if (existSlider == null) return NotFound();
            if (slider.ImageFile != null)
            {
                if (slider.ImageFile.ContentType != "image/jpeg" && slider.ImageFile.ContentType != "image/png")
                {
                    ModelState.AddModelError("ImageFile", "file type must be jpeg or png");
                    return View();
                }

                if (slider.ImageFile.Length > 4194304)
                {
                    ModelState.AddModelError("ImageFile", "file size must be less than 4mb");
                    return View();
                }

                string fileName = slider.ImageFile.FileName;

                if (fileName.Length > 64)
                {
                    fileName = fileName.Substring(slider.ImageFile.FileName.Length - 64, 64);
                }

                slider.Image = (Guid.NewGuid().ToString() + (fileName));

                string path = Path.Combine(_env.WebRootPath, "uploads/sliders", slider.Image);

                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    slider.ImageFile.CopyTo(stream);
                }

                if (existSlider.Image != null)
                {
                    string existPath = Path.Combine(_env.WebRootPath, "uploads/sliders", existSlider.Image);
                    if (System.IO.File.Exists(existPath))
                        System.IO.File.Delete(existPath);
                }

                existSlider.Image = slider.Image;
            }
            else
            {
                if (slider.Image == null && existSlider.Image != null)
                {
                    string existPath = Path.Combine(_env.WebRootPath, "uploads/sliders", existSlider.Image);
                    if (System.IO.File.Exists(existPath))
                        System.IO.File.Delete(existPath);

                    existSlider.Image = null;
                }
            }

            if (existSlider == null) return NotFound();
            existSlider.Title1 = slider.Title1;
            existSlider.Title2 = slider.Title2;
            existSlider.Desc = slider.Desc;
            existSlider.BtnText = slider.BtnText;
            existSlider.BtnUrl = slider.BtnUrl;
            existSlider.Order = slider.Order;
            existSlider.Image = slider.Image;
            existSlider.LastUpdateDate = DateTime.UtcNow.AddHours(4);

            _context.SaveChanges();
            return RedirectToAction("index");
        }
        //DELETE ACTION
        public IActionResult Delete(int id)
        {
            Slider existSlider = _context.Sliders.FirstOrDefault(x => x.Id == id);

            if (existSlider == null)
                return NotFound();

            _context.Sliders.Remove(existSlider);

            string existPath = Path.Combine(_env.WebRootPath, "uploads/sliders", existSlider.Image);
            if (System.IO.File.Exists(existPath))
                System.IO.File.Delete(existPath);

            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
