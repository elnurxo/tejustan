using ElnurJUAN.Areas.Manage.ViewModels;
using ElnurJUAN.Models;
using Microsoft.AspNetCore.Authorization;
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
    public class DashboardController : Controller
    {
        private readonly JuanContext _context;
        public DashboardController (JuanContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            DashBoardViewModel dashboardVM = new DashBoardViewModel
            {
                Partnerships = _context.Partnerships.ToList(),
                Messages = _context.Messages.ToList(),
                AppUsers = _context.AppUsers.ToList(),
                Orders = _context.Orders.ToList(),
                Shoes = _context.Shoes.Include(x => x.Brand).Include(x => x.Category).Include(x => x.ShoeImages).Where(x => !x.IsDeleted).Take(10).ToList()
            };
            return View(dashboardVM);
        }
    }
}
