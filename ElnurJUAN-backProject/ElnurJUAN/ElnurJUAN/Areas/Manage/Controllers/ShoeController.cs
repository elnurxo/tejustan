    using ElnurJUAN.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using ElnurJUAN.Helpers;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ElnurJUAN.Areas.Manage.Controllers
{
    [Area("manage")]
    [Authorize(Roles = "SuperAdmin")]
    public class ShoeController : Controller
    {
        private readonly JuanContext _context;
        private readonly IWebHostEnvironment _env;

        public ShoeController(JuanContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        //INDEX ACTION
        public IActionResult Index(string filter, int page = 1)
        {
            ViewBag.Filter = filter;

            var shoes = _context.Shoes.Include(x => x.Brand).Include(x => x.Category).Include(x=>x.ShoeComments).Include(x => x.Gender).Include(x => x.ShoeImages).AsQueryable();

            if (filter != null)
                shoes = shoes.Where(x => x.IsDeleted == (filter=="true"?true:false));

            string pageSizeStr = _context.Settings.FirstOrDefault(x => x.Key == "PageSize").Value;
            int pageSize = pageSizeStr == null ? 3 : int.Parse(pageSizeStr);
            return View(PagenatedList<Shoe>.Create(shoes, page, pageSize));
        }
        //CREATE ACTION
        public IActionResult Create()   
        {
            ViewBag.Brands = _context.Brands.Where(x => !x.IsDeleted).ToList();
            ViewBag.Colors = _context.Colors.Where(x => !x.IsDeleted).ToList();
            ViewBag.Categories = _context.Categories.Where(x => !x.IsDeleted).ToList();
            ViewBag.Genders = _context.Genders.ToList();

            return View();
        }
        // CREATE POST  ACTION------------------
        [HttpPost]
        public IActionResult Create(Shoe shoe)
        {
            ViewBag.Brands = _context.Brands.Where(x => !x.IsDeleted).ToList();
            ViewBag.Colors = _context.Colors.ToList();
            ViewBag.Categories = _context.Categories.Where(x => !x.IsDeleted).ToList();
            ViewBag.Genders = _context.Genders.ToList();


            if (shoe.CostPrice < 0)
            {
                ModelState.AddModelError("CostPrice", "Cost Price cannot be Negative");
                return View();
            }
            if (shoe.SalePrice < 0)
            {
                ModelState.AddModelError("SalePrice", "Sale Price cannot be Negative");
                return View();
            }
            if (shoe.DiscountPercent < 0)
            {
                ModelState.AddModelError("DiscountPercent", "Discount Percent cannot be Negative");
                return View();
            }
            if (shoe.CostPrice > shoe.SalePrice)
            {
                ModelState.AddModelError("SalePrice", "Cost Price cannot be less than SalePrice");
                return View();
            }
            //IMAGE 
            if (shoe.ImageFile == null)
            {
                ModelState.AddModelError("Image", "Image is required");
                return View();
            }
            else
            {
                if (shoe.ImageFile.ContentType != "image/jpeg" && shoe.ImageFile.ContentType != "image/png")
                {
                    ModelState.AddModelError("PosterFile", "file type must be image/jpeg or image/png");
                    return View();
                }

                if (shoe.ImageFile.Length > 4194304)
                {
                    ModelState.AddModelError("PosterFile", "file size must be less than 4mb");
                    return View();
                }
            }
            //Shoe Images Multiple
            if (shoe.Files != null)
            {
                foreach (var file in shoe.Files)
                {
                    if (file.ContentType != "image/jpeg" && file.ContentType != "image/png")
                    {
                        ModelState.AddModelError("Files", "file type must be image/jpeg or image/png");
                        return View();
                    }

                    if (file.Length > 4194304)
                    {
                        ModelState.AddModelError("Files", "file size must be less than 4mb");
                        return View();
                    }


                }
            }

            if (!_context.Brands.Any(x => x.Id == shoe.BrandId && !x.IsDeleted))
            {
                ModelState.AddModelError("BrandId", "Brand not found");
                return View();
            }

            if (!_context.Genders.Any(x => x.Id == shoe.GenderId))
            {
                ModelState.AddModelError("GenderId", "Gender not found");
                return View();
            }

            shoe.ShoeColors = new List<ShoeColor>();
            shoe.ShoeImages = new List<ShoeImage>();

            if (shoe.ColorIds != null)
            {
                foreach (var colorId in shoe.ColorIds)
                {
                    if (_context.Colors.Any(x => x.Id == colorId))
                    {
                        ShoeColor shoeColor = new ShoeColor
                        {
                            ColorId = colorId,
                        };
                        shoe.ShoeColors.Add(shoeColor);
                    }
                    else
                    {
                        ModelState.AddModelError("ColorIds", "Colors's not found");
                        return View();
                    }
                }
            }
            ShoeImage posterImage = new ShoeImage
            {

                PosterStatus = true,
                Image = FileManager.Save(_env.WebRootPath, "uploads/products", shoe.ImageFile)
            };
            shoe.ShoeImages.Add(posterImage);

            if (shoe.Files != null)
            {
                foreach (var file in shoe.Files)
                {
                    ShoeImage shoeImage = new ShoeImage
                    {
                        PosterStatus = false,
                        Image = FileManager.Save(_env.WebRootPath, "uploads/products", file)
                    };
                    shoe.ShoeImages.Add(shoeImage);
                }
            }



            string CodePrefix = "XO";
            if (_context.Shoes.OrderByDescending(x => x.CodeNum).FirstOrDefault() == null)
            {
                int CodeNum = 1001;            
                shoe.CodeNum = CodeNum;
                shoe.CodePref = CodePrefix;
            }
            else
            {
                var lastShoe = _context.Shoes.OrderByDescending(x => x.CodeNum).FirstOrDefault();
                int CodeNum = lastShoe == null ? 1001 : lastShoe.CodeNum + 1;
                shoe.CodeNum = CodeNum;
                shoe.CodePref = CodePrefix;
            }

            shoe.CreatedAt = DateTime.UtcNow.AddHours(4);
            _context.Shoes.Add(shoe);
            _context.SaveChanges();

            return RedirectToAction("index");
        }
        // EDIT ACTION
        public IActionResult Edit(int id)
        {
            Shoe shoe = _context.Shoes.Include(x => x.Brand).Include(x => x.ShoeImages).Include(x => x.ShoeColors).Include(x => x.Category).Include(x => x.Gender).FirstOrDefault(x => x.Id == id);
            if (shoe == null) return NotFound();

            ViewBag.Brands = _context.Brands.Where(x => !x.IsDeleted).ToList();
            ViewBag.Colors = _context.Colors.Where(x => !x.IsDeleted).ToList();
            ViewBag.Categories = _context.Categories.Where(x => !x.IsDeleted).ToList();
            ViewBag.Genders = _context.Genders.ToList();

            return View(shoe);
        }
        [HttpPost]
        public IActionResult Edit(Shoe shoe)
        {
            Shoe existShoe = _context.Shoes.Include(x => x.Brand).Include(x => x.ShoeColors).Include(x=>x.ShoeImages).Include(x => x.Category).Include(x => x.Gender).FirstOrDefault(x => x.Id == shoe.Id);

            if (existShoe == null) return NotFound();

            if (!_context.Brands.Any(x => x.Id == shoe.BrandId && !x.IsDeleted))
            {
                ModelState.AddModelError("BrandId", "Brand not found");
                return View();
            }

            if (!_context.Genders.Any(x => x.Id == shoe.GenderId))
            {
                ModelState.AddModelError("GenderId", "Gender not found");
                return View();
            }

            //IMAGE
            if (shoe.ImageFile != null && shoe.ImageFile.ContentType != "image/jpeg" && shoe.ImageFile.ContentType != "image/png")
            {
                ModelState.AddModelError("PosterFile", "file type must be image/jpeg or image/png");
                return View();
            }

            if (shoe.ImageFile != null && shoe.ImageFile.Length > 4194304)
            {
                ModelState.AddModelError("PosterFile", "file size must be less than 4mb");
                return View();
            }
            if (shoe.Files != null)
            {
                foreach (var file in shoe.Files)
                {
                    if (file.ContentType != "image/jpeg" && file.ContentType != "image/png")
                    {
                        ModelState.AddModelError("Files", "file type must be image/jpeg or image/png");
                        return View();
                    }

                    if (file.Length > 4194304)
                    {
                        ModelState.AddModelError("Files", "file size must be less than 4mb");
                        return View();
                    }
                }
            }
            ShoeImage poster = existShoe.ShoeImages.FirstOrDefault(x => x.PosterStatus == true);

            if (shoe.ImageFile != null)
            {
                string newPosterImg = FileManager.Save(_env.WebRootPath, "uploads/products", shoe.ImageFile);
                if (poster != null)
                {
                    FileManager.Delete(_env.WebRootPath, "uploads/products", poster.Image);
                    poster.Image = newPosterImg;
                }
                else
                {
                    poster = new ShoeImage { Image = newPosterImg, PosterStatus = true };
                    existShoe.ShoeImages.Add(poster);
                }
            }

            existShoe.ShoeImages.RemoveAll(x => x.PosterStatus == false && !shoe.FileIds.Contains(x.Id));

            if (shoe.Files != null)
            {
                foreach (var file in shoe.Files)
                {
                    ShoeImage shoeImage = new ShoeImage
                    {
                        PosterStatus = false,
                        Image = FileManager.Save(_env.WebRootPath, "uploads/products", file)
                    };
                    existShoe.ShoeImages.Add(shoeImage);
                }
            }

            if (existShoe == null) return NotFound();


            if (shoe.ColorIds != null)
            {
                existShoe.ShoeColors.RemoveAll(x => !shoe.ColorIds.Contains(x.Id));
                foreach (var colors in shoe.ColorIds)
                {
                    ShoeColor color = new ShoeColor
                    {
                        ShoeId = shoe.Id,
                        ColorId = colors
                    };
                    existShoe.ShoeColors.Add(color);
                }
            }


            existShoe.Name = shoe.Name;
            existShoe.Desc = shoe.Desc;
            existShoe.SalePrice = shoe.SalePrice;
            existShoe.CostPrice = shoe.CostPrice;
            existShoe.DiscountPercent = shoe.DiscountPercent;
            existShoe.IsAvailable = shoe.IsAvailable;
            existShoe.BrandId = shoe.BrandId;
            existShoe.CategoryId = shoe.CategoryId;
            existShoe.GenderId = shoe.GenderId;
            existShoe.LastUpdateDate = DateTime.UtcNow.AddHours(4);


            _context.SaveChanges();


            return RedirectToAction("index");
        }

        //DELETE ACTION
        public IActionResult Delete(int id)
        {
            Shoe existShoe = _context.Shoes.FirstOrDefault(x => x.Id == id && !x.IsDeleted);

            if (existShoe == null)
                return NotFound();


            existShoe.IsDeleted = true;
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        //RESTORE ACTION
        public IActionResult Restore(int id)
        {
            Shoe existShoe = _context.Shoes.FirstOrDefault(x => x.Id == id && x.IsDeleted);

            if (existShoe == null)
                return NotFound();

            existShoe.IsDeleted = false;
            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
