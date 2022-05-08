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
    public class CommentController : Controller
    {
        private readonly JuanContext _context;
        private readonly IWebHostEnvironment _env;

        public CommentController(JuanContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        //INDEX ACTION
        public IActionResult Index(int id,int page = 1)
        {
            var reviews = _context.ShoeComments.Include(x => x.AppUser).Include(x => x.Shoe).Where(x=>x.ShoeId==id).AsQueryable();
            string pageSizeStr = _context.Settings.FirstOrDefault(x => x.Key == "PageSize").Value;
            int pageSize = string.IsNullOrWhiteSpace(pageSizeStr) ? 3 : int.Parse(pageSizeStr);
            return View(PagenatedList<ShoeComment>.Create(reviews, page, pageSize));
        }
        //DELETE ACTION
        public IActionResult Delete(int id)
        {
            ShoeComment existReview = _context.ShoeComments.FirstOrDefault(x => x.Id == id);

            if (existReview == null)
                return NotFound();

            _context.ShoeComments.Remove(existReview);
            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
