using ElnurJUAN.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElnurJUAN.Areas.Manage.Controllers
{
    [Area("manage")]
    [Authorize(Roles = "SuperAdmin")]
    public class MessageController : Controller
    {
        private readonly JuanContext _context;
        private readonly IWebHostEnvironment _env;

        public MessageController(JuanContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        //INDEX ACTION
        public IActionResult Index(int id, int page = 1)
        {
            var messages = _context.Messages.AsQueryable();
            string pageSizeStr = _context.Settings.FirstOrDefault(x => x.Key == "PageSize").Value;
            int pageSize = string.IsNullOrWhiteSpace(pageSizeStr) ? 3 : int.Parse(pageSizeStr);
            return View(PagenatedList<Message>.Create(messages, page, pageSize));
        }
        //DELETE ACTION
        public IActionResult Delete(int id)
        {
            Message existMessage = _context.Messages.FirstOrDefault(x => x.Id == id);

            if (existMessage == null)
                return NotFound();

            _context.Messages.Remove(existMessage);
            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
