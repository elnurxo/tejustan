using ElnurJUAN.Models;
using ElnurJUAN.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElnurJUAN.Controllers
{
    public class OrderController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly JuanContext _context;

        public OrderController(UserManager<AppUser> userManager, JuanContext context)
        {
            _userManager = userManager;
            _context = context;
        }
        public IActionResult Checkout()
        {
            AppUser member = null;
            if (User.Identity.IsAuthenticated)
            {
                member = _userManager.Users.FirstOrDefault(x => x.UserName == User.Identity.Name && !x.IsAdmin);
            }


            CheckoutViewModel checkoutVM = new CheckoutViewModel
            {
                Basket = _getBasket(member),
                Order = new Order
                {
                    Email = member?.Email,
                    PhoneNumber = member?.PhoneNumber,
                    FullName = member?.FullName,
                    Address = member?.Address,
                    City = member?.City,
                    Country = member?.Country
                }
            };
            return View(checkoutVM);
        }

        private BasketViewModel _getBasket(AppUser member)
        {
            BasketViewModel basketVM = new BasketViewModel
            {
                BasketItems = new List<ShoeBasketItemViewModel>()
            };

            List<BasketItemViewModel> items = new List<BasketItemViewModel>();

            if (member == null)
            {
                string basketItemsStr = HttpContext.Request.Cookies["basket"];

                if (!string.IsNullOrWhiteSpace(basketItemsStr))
                    items = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(basketItemsStr);
            }
            else
            {
                items = _context.BasketItems.Where(x => x.AppUserId == member.Id).Select(b => new BasketItemViewModel { ShoeId = b.ShoeId, Count = b.Count }).ToList();
            }

            foreach (var item in items)
            {
                Shoe shoe = _context.Shoes.FirstOrDefault(x => x.Id == item.ShoeId);
                ShoeBasketItemViewModel bookItem = new ShoeBasketItemViewModel
                {
                    Shoe = shoe,
                    Count = item.Count
                };

                decimal totalPrice = shoe.DiscountPercent > 0 ? (shoe.SalePrice * (1 - shoe.DiscountPercent / 100)) : shoe.SalePrice;
                basketVM.TotalPrice += totalPrice * item.Count;

                basketVM.BasketItems.Add(bookItem);
            }

            return basketVM;
        }

        [HttpPost]
        public IActionResult Create(Order order)
        {

            AppUser member = null;
            if (User.Identity.IsAuthenticated)
            {
                member = _userManager.Users.FirstOrDefault(x => x.UserName == User.Identity.Name && !x.IsAdmin);
            }
            if (member == null)
            {
                TempData["Page"] = "Register";
                return RedirectToAction("register", "account");
            }
            CheckoutViewModel checkoutVM = new CheckoutViewModel
            {
                Basket = _getBasket(member),
                Order = order
            };

            if (!ModelState.IsValid)
                return View("Checkout", checkoutVM);

            if (checkoutVM.Basket.BasketItems.Count == 0)
            {
                ModelState.AddModelError("", "You have to choose at least one product!");
                return View("Checkout", checkoutVM);
            }


            order.AppUserId = member?.Id;
            order.CreatedAt = DateTime.UtcNow.AddHours(4);
            order.LastUpdateDate = DateTime.UtcNow.AddHours(4);
            order.Status = Enums.OrderStatus.Pending;

            order.OrderItems = new List<OrderItem>();

            foreach (var item in checkoutVM.Basket.BasketItems)
            {
                OrderItem orderItem = new OrderItem
                {
                    ShoeId = item.Shoe.Id,
                    SalePrice = item.Shoe.SalePrice,
                    CostPrice = item.Shoe.CostPrice,
                    DiscountedPrice = item.Shoe.DiscountPercent > 0 ? (item.Shoe.SalePrice * (1 - item.Shoe.DiscountPercent / 100)) : item.Shoe.SalePrice,
                    Count = item.Count
                };

                order.OrderItems.Add(orderItem);
                order.TotalPrice += orderItem.DiscountedPrice * orderItem.Count;
            }

            _context.Orders.Add(order);

            if (member == null && TempData["Page2"].ToString() != "Checkout")
                HttpContext.Response.Cookies.Delete("basket");  
            else
                _context.BasketItems.RemoveRange(_context.BasketItems.Where(x => x.AppUserId == member.Id));

            _context.SaveChanges();

            TempData["Success"] = "Product Ordered";
            return RedirectToAction("profile", "account");
        }

        //Cart Action
        public async Task<IActionResult> Cart(int page = 1)
        {
            AppUser member = await _userManager.Users.Where(x => x.UserName == User.Identity.Name).FirstOrDefaultAsync();
              if (member==null)
            {
                return RedirectToAction("login","account");
            }


            var orders = _context.Orders.Include(x => x.OrderItems).ThenInclude(x => x.Shoe).AsQueryable();
            string pageSizeStr = _context.Settings.FirstOrDefault(x => x.Key == "PageSize").Value;
            int pageSize = pageSizeStr == null ? 3 : int.Parse(pageSizeStr);
            return View(PagenatedList<Order>.Create(orders, page, pageSize));
        }
    }
}
