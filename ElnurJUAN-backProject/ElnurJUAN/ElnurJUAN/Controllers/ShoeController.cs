using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ElnurJUAN.Models;
using ElnurJUAN.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace ElnurJUAN.Controllers
{
    public class ShoeController : Controller
    {
        private readonly JuanContext _context;
        private readonly UserManager<AppUser> _userManager;

        public ShoeController(JuanContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        //INDEX ACTION
        public IActionResult Index(int? genderId, int? categoryId,decimal? minPrice, decimal? maxPrice, List<int> colorIds, int page = 1)
        {

            var shoes = _context.Shoes
                .Include(x => x.Brand)
                .Include(x => x.Category)
                .Include(x => x.ShoeColors)
                .Include(x=>x.Gender)
                .Include(x => x.ShoeImages)
                .Include(x=>x.ShoeComments)
                .Where(x => !x.IsDeleted).Where(x=>x.IsAvailable);

            ViewBag.CategoryId = categoryId;
            ViewBag.GenderId = genderId;
            ViewBag.PageIndex = page;
            ViewBag.ColorIds = colorIds;

            ViewBag.TotalShoes = shoes.Count();

            ShopViewModel shoeVM = new ShopViewModel();

            if (genderId > 3 || genderId < 0)
            {
                return BadRequest();
            }
            if (genderId != null)
            {
                shoes = shoes.Where(x => x.GenderId == genderId);
            }
            if (categoryId != null)
            {
                shoes = shoes.Where(x => x.CategoryId == categoryId);
            }

            if (colorIds != null && colorIds.Count > 0)
                shoes = shoes.Where(x => x.ShoeColors.Any(sc => colorIds.Contains(sc.ColorId)));

            if (shoes.Any())
            {
                shoeVM.MinPrice = shoes.Min(x => x.SalePrice);
                shoeVM.MaxPrice = shoes.Max(x => x.SalePrice);
            }

            ViewBag.FilterMinPrice = minPrice ?? shoeVM.MinPrice;
            ViewBag.FilterMaxPrice = maxPrice ?? shoeVM.MaxPrice;

            if (minPrice != null && maxPrice != null)
                shoes = shoes.Where(x => x.SalePrice >= minPrice && x.SalePrice <= maxPrice);

            ViewBag.TotalPages = (int)Math.Ceiling(shoes.Count() / 6d);

            shoeVM.Settings = _context.Settings.ToList();
            shoeVM.Shoes = shoes.Skip((page - 1) * 6).Take(6).ToList();
            shoeVM.Genders = _context.Genders.Include(x => x.Shoes).ToList();
            shoeVM.Categories = _context.Categories.Include(x => x.Shoes).Where(x => !x.IsDeleted).ToList();
            shoeVM.Colors = _context.Colors.Where(x=>!x.IsDeleted).ToList();
            shoeVM.FilterColorIds = colorIds;
            return View(shoeVM);
        }

        //GET SHOE ACTION
        public IActionResult GetShoe(int id)
        {
            Shoe shoe = _context.Shoes.Include(x => x.Brand).Include(x=>x.Category).Include(x=>x.ShoeImages).Include(x=>x.ShoeComments).Include(x=>x.Gender).Include(x=>x.ShoeColors).ThenInclude(x=>x.Color).FirstOrDefault(x => x.Id == id);
            if (shoe == null)
                return NotFound();
            return PartialView("_ShoeModalPartialView",shoe);
        }


        //DETAIL ACTION
        public IActionResult Detail(int id)
        {
            Shoe shoe = _context.Shoes
                .Include(x => x.Gender).Include(x => x.Brand).Include(x => x.ShoeImages).Include(x => x.Category)
                .Include(x => x.ShoeColors).ThenInclude(x => x.Color)
                .Include(x => x.ShoeComments).ThenInclude(c => c.AppUser)
                .FirstOrDefault(x => x.Id == id && !x.IsDeleted);
            if (shoe == null) return PartialView("_ErrorPagePartialView");

            ShoeDetailViewModel shoeDetailVM = new ShoeDetailViewModel
            {
                Shoe = shoe,
                Comment = new ShoeComment { ShoeId = id },
                RelatedShoes = _context.Shoes.Include(x => x.ShoeImages).Where(x => x.CategoryId == shoe.CategoryId).Take(6).ToList()
            };

            return View(shoeDetailVM); 
        }

        //COMMENT ACTION
        [HttpPost]
        [Authorize(Roles = "Member")]
        public IActionResult Comment(ShoeComment comment)
        {

            AppUser member = null;
            if (User.Identity.IsAuthenticated)
            {
                member = _userManager.Users.FirstOrDefault(x => x.UserName == User.Identity.Name && !x.IsAdmin);
            }
            if (member == null)
                return RedirectToAction("login", "account");

            Shoe shoe = _context.Shoes
               .Include(x => x.Gender).Include(x => x.Brand).Include(x => x.ShoeImages).Include(x => x.Category)
               .Include(x => x.ShoeColors).ThenInclude(x => x.Color)
               .Include(x => x.ShoeComments).ThenInclude(c => c.AppUser)
               .FirstOrDefault(x => x.Id == comment.ShoeId && !x.IsDeleted);

            if (shoe == null) return NotFound();

            if (!ModelState.IsValid)
            {

                ShoeDetailViewModel shoeDetailVM = new ShoeDetailViewModel
                {
                    Shoe = shoe,
                    Comment = comment,
                    RelatedShoes = _context.Shoes.Include(x => x.ShoeImages).Where(x => x.CategoryId == shoe.CategoryId).Take(6).ToList()
                };

                return View("Detail", shoeDetailVM);
            }

            comment.AppUserId = member.Id;

            comment.CreatedAt = DateTime.UtcNow.AddHours(4);
            shoe.ShoeComments.Add(comment);
            shoe.Rate = (int)Math.Ceiling(shoe.ShoeComments.Sum(x => x.Rate) / (double)shoe.ShoeComments.Count);

            _context.SaveChanges();

            return RedirectToAction("detail", new { id = comment.ShoeId });
        }
        // ADD BASKET
        public IActionResult AddBasket(int id)
        {
            if (!_context.Shoes.Any(x => x.Id == id && !x.IsDeleted))
                return PartialView("_ErrorPagePartialView");

            AppUser member = null;
            if (User.Identity.IsAuthenticated)
            {
                member = _userManager.Users.FirstOrDefault(x => x.UserName == User.Identity.Name && !x.IsAdmin);
            }

            if (member == null)
            {
                string basketItemsStr = HttpContext.Request.Cookies["basket"];
                List<BasketItemViewModel> items = new List<BasketItemViewModel>();

                if (!string.IsNullOrWhiteSpace(basketItemsStr))
                    items = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(basketItemsStr);

                BasketItemViewModel item = items.FirstOrDefault(x => x.ShoeId == id);

                if (item == null)
                {
                    item = new BasketItemViewModel { ShoeId = id, Count = 1 };
                    items.Add(item);
                }
                else
                    item.Count++;

                basketItemsStr = JsonConvert.SerializeObject(items);
                HttpContext.Response.Cookies.Append("basket", basketItemsStr);

                return PartialView("_BasketPartial", _getBasket(items));
            }
            else
            {
                BasketItem item = _context.BasketItems.FirstOrDefault(x => x.AppUserId == member.Id && x.ShoeId == id);

                if (item == null)
                {
                    item = new BasketItem
                    {
                        AppUserId = member.Id,
                        ShoeId = id,
                        CreatedAt = DateTime.UtcNow.AddHours(4),
                        Count = 1
                    };
                    _context.BasketItems.Add(item);
                }
                else
                {
                    item.Count++;
                }

                _context.SaveChanges();

                var items = _context.BasketItems.Where(x => x.AppUserId == member.Id).ToList();
                return PartialView("_BasketPartial", _getBasket(items));
            }
        }
        //REMOVE BASKET
        public IActionResult RemoveBasket(int id)
        {
            if (!_context.Shoes.Any(x => x.Id == id && !x.IsDeleted))
                return PartialView("_ErrorPagePartialView");

            AppUser member = null;
            if (User.Identity.IsAuthenticated)
            {
                member = _userManager.Users.FirstOrDefault(x => x.UserName == User.Identity.Name && !x.IsAdmin);
            }

            if (member == null)
            {
                string basketItemsStr = HttpContext.Request.Cookies["basket"];
                List<BasketItemViewModel> items = new List<BasketItemViewModel>();

                if (!string.IsNullOrWhiteSpace(basketItemsStr))
                    items = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(basketItemsStr);

                BasketItemViewModel item = items.FirstOrDefault(x => x.ShoeId == id);

                if (item.Count > 0)
                {
                    item.Count--;
                    if (item.Count == 0)
                    {
                        items.Remove(item);
                    }
                }
                else
                    items.Remove(item);

                basketItemsStr = JsonConvert.SerializeObject(items);

                HttpContext.Response.Cookies.Append("basket", basketItemsStr);

                return PartialView("_BasketPartial", _getBasket(items));
            }
            else
            {
                BasketItem item = _context.BasketItems.FirstOrDefault(x => x.AppUserId == member.Id && x.ShoeId == id);



                if (item.Count > 0)
                {
                    item.Count--;
                    if (item.Count == 0)
                    {
                        _context.BasketItems.Remove(item);
                    }
                }
                else
                    _context.BasketItems.Remove(item);

                _context.SaveChanges();

                var items = _context.BasketItems.Where(x => x.AppUserId == member.Id).ToList();
                return PartialView("_BasketPartial", _getBasket(items));
            }
        }
        private BasketViewModel _getBasket(List<BasketItemViewModel> basketItems)
        {
            BasketViewModel basketVM = new BasketViewModel
            {
                BasketItems = new List<ShoeBasketItemViewModel>(),
                TotalPrice = 0
            };

            foreach (var item in basketItems)
            {
                Shoe shoe = _context.Shoes.Include(x => x.ShoeImages).FirstOrDefault(x => x.Id == item.ShoeId);
                ShoeBasketItemViewModel bookBasketItem = new ShoeBasketItemViewModel
                {
                    Shoe = shoe,
                    Count = item.Count
                };

                basketVM.BasketItems.Add(bookBasketItem);
                decimal totalPrice = shoe.DiscountPercent > 0 ? (shoe.SalePrice * (1 - shoe.DiscountPercent / 100)) : shoe.SalePrice;
                basketVM.TotalPrice += totalPrice * item.Count;
            }

            return basketVM;
        }

        private BasketViewModel _getBasket(List<BasketItem> basketItems)
        {
            BasketViewModel basketVM = new BasketViewModel
            {
                BasketItems = new List<ShoeBasketItemViewModel>(),
                TotalPrice = 0
            };

            foreach (var item in basketItems)
            {
                Shoe shoe = _context.Shoes.Include(x => x.ShoeImages).FirstOrDefault(x => x.Id == item.ShoeId);
                ShoeBasketItemViewModel bookBasketItem = new ShoeBasketItemViewModel
                {
                    Shoe = shoe,
                    Count = item.Count
                };

                basketVM.BasketItems.Add(bookBasketItem);
                decimal totalPrice = shoe.DiscountPercent > 0 ? (shoe.SalePrice * (1 - shoe.DiscountPercent / 100)) : shoe.SalePrice;
                basketVM.TotalPrice += totalPrice * item.Count;
            }

            return basketVM;
        }
    }
}
