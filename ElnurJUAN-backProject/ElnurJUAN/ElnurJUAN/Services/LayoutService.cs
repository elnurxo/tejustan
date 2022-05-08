using ElnurJUAN.Models;
using ElnurJUAN.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElnurJUAN.Services
{
    public class LayoutService
    {
        private readonly JuanContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LayoutService(JuanContext context, UserManager<AppUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
        }
        public Dictionary<string, string> GetSettings()
        {
            return _context.Settings.ToDictionary(x => x.Key, x => x.Value);
        }
        public BasketViewModel GetBasket()
        {
            BasketViewModel basketVM = new BasketViewModel
            {
                BasketItems = new List<ShoeBasketItemViewModel>(),
                TotalPrice = 0
            };

            List<BasketItemViewModel> basketItems = new List<BasketItemViewModel>();
            AppUser member = null;
            if (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                member = _userManager.Users.FirstOrDefault(x => x.UserName == _httpContextAccessor.HttpContext.User.Identity.Name && !x.IsAdmin);
            }

            if (member == null)
            {
                var baksetStr = _httpContextAccessor.HttpContext.Request.Cookies["basket"];

                if (!string.IsNullOrWhiteSpace(baksetStr))
                    basketItems = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(baksetStr);

            }
            else
            {
                basketItems = _context.BasketItems.Where(x => x.AppUserId == member.Id).Select(x => new BasketItemViewModel { ShoeId = x.ShoeId, Count = x.Count }).ToList();
            }


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
