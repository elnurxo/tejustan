//using ElnurJUAN.Models;
using ElnurJUAN.Models;
using ElnurJUAN.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ElnurJUAN.Controllers
{
    public class HomeController : Controller
    {
        private readonly JuanContext _context;
        public HomeController(JuanContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel homeVM = new HomeViewModel
            {
                Sliders = _context.Sliders.OrderBy(x => x.Order).ToList(),
                Features = _context.Features.ToList(),
                Settings = _context.Settings.ToList(),
                Partnerships = _context.Partnerships.ToList(),
                Shoes = _context.Shoes.Include(x=>x.Brand).Include(x=>x.Category).Include(x => x.ShoeImages).Where(x=>!x.IsDeleted).Take(10).ToList(),
                MostRatedShoes = _context.Shoes.Include(x => x.Brand).Include(x => x.Category).Include(x=>x.ShoeImages).Where(x => !x.IsDeleted).OrderByDescending(x=>x.Rate).Take(6).ToList()
                
            };
            return View(homeVM);
        }

        public IActionResult Error()
        {
            return PartialView("_ErrorPagePartialView");
        }

     
    }
}
