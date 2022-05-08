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
    public class FeatureController : Controller
    {
        private readonly JuanContext _context;
        private readonly IWebHostEnvironment _env;

        public FeatureController(JuanContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        //INDEX ACTION
        public IActionResult Index(int page = 1)
        {
            string pageSizeStr = _context.Settings.FirstOrDefault(x => x.Key == "PageSize").Value;
            int pageSize = string.IsNullOrWhiteSpace(pageSizeStr) ? 3 : int.Parse(pageSizeStr);
            return View(PagenatedList<Feature>.Create(_context.Features.AsQueryable(), page, pageSize));
        }
        //CREATE ACTION
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Feature feature)
        {
            if (feature.ImageFile == null)
                ModelState.AddModelError("ImageFile", "Image file is required!");

            if (!ModelState.IsValid)
                return View();

            if (feature.ImageFile.ContentType != "image/jpeg" && feature.ImageFile.ContentType != "image/png")
            {
                ModelState.AddModelError("ImageFile", "File type must be jpeg or png");
                return View();
            }

            if (feature.ImageFile.Length > 2097152)
            {
                ModelState.AddModelError("ImageFile", "file size must be less than 2mb");
                return View();
            }

            string fileName = feature.ImageFile.FileName;

            if (fileName.Length > 64)
            {
                fileName = fileName.Substring(feature.ImageFile.FileName.Length - 64, 64);
            }

            feature.Icon = (Guid.NewGuid().ToString() + (fileName));

            string path = Path.Combine(_env.WebRootPath, "uploads/features", feature.Icon);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                feature.ImageFile.CopyTo(stream);
            }


            _context.Features.Add(feature);
            _context.SaveChanges();

            return RedirectToAction("index");
        }
        //EDIT ACTION
        public IActionResult Edit(int id)
        {
            Feature feature = _context.Features.FirstOrDefault(x => x.Id == id);

            if (feature == null) return NotFound();

            return View(feature);
        }

        [HttpPost]
        public IActionResult Edit(Feature feature)
        {
            if (!ModelState.IsValid)
                return View();

            Feature existFeature = _context.Features.FirstOrDefault(x => x.Id == feature.Id);
            if (existFeature == null) return NotFound();
            if (existFeature.ImageFile != null)
            {
                if (existFeature.ImageFile.ContentType != "image/jpeg" && existFeature.ImageFile.ContentType != "image/png")
                {
                    ModelState.AddModelError("ImageFile", "file type must be jpeg or png");
                    return View();
                }

                if (feature.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile", "file size must be less than 2mb");
                    return View();
                }

                string fileName = feature.ImageFile.FileName;

                if (fileName.Length > 64)
                {
                    fileName = fileName.Substring(feature.ImageFile.FileName.Length - 64, 64);
                }

                feature.Icon = (Guid.NewGuid().ToString() + (fileName));

                string path = Path.Combine(_env.WebRootPath, "uploads/sliders", feature.Icon);

                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    feature.ImageFile.CopyTo(stream);
                }

                if (existFeature.Icon != null)
                {
                    string existPath = Path.Combine(_env.WebRootPath, "uploads/features", existFeature.Icon);
                    if (System.IO.File.Exists(existPath))
                        System.IO.File.Delete(existPath);
                }

                existFeature.Icon = feature.Icon;
            }
            else
            {
                if (feature.Icon == null && existFeature.Icon != null)
                {
                    string existPath = Path.Combine(_env.WebRootPath, "uploads/sliders", existFeature.Icon);
                    if (System.IO.File.Exists(existPath))
                        System.IO.File.Delete(existPath);

                    existFeature.Icon = null;
                }
            }

            if (existFeature == null) return NotFound();
            existFeature.Title = feature.Title;
            existFeature.Desc = feature.Desc;
            existFeature.Icon = feature.Icon;

            _context.SaveChanges();
            return RedirectToAction("index");
        }

        //DELETE ACTION
        public IActionResult Delete(int id)
        {
            Feature existFeature = _context.Features.FirstOrDefault(x => x.Id == id);

            if (existFeature == null)
                return NotFound();

            _context.Features.Remove(existFeature);

            string existPath = Path.Combine(_env.WebRootPath, "uploads/features", existFeature.Icon);
            if (System.IO.File.Exists(existPath))
                System.IO.File.Delete(existPath);

            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
