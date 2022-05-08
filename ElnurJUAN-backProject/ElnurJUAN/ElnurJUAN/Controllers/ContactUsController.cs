using ElnurJUAN.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElnurJUAN.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly JuanContext _context;
        private readonly UserManager<AppUser> _userManager;

        public ContactUsController(JuanContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        //INDEX ACTION
        public IActionResult Index()
        {
            //var settings = _context.Settings.ToList();      
            return View();
        }
        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            if (!ModelState.IsValid)
            {
                return View("index", message);
            }
            if (message.Name==null)
            {
                ModelState.AddModelError("Name", "Name is Required!");
                return View();
            }
            if (message.Email == null)
            {
                ModelState.AddModelError("Email", "Email is Required!");
                return View();
            }
            if (message.Subject == null)
            {
                ModelState.AddModelError("Subject", "Subject is Required!");
                return View();
            }
            if (message.Phone == null)
            {
                ModelState.AddModelError("Phone", "Phone is Required!");
                return View();
            }


            _context.Messages.Add(message);
            _context.SaveChanges();
            TempData["Success"] = "Message Sent!";
            return RedirectToAction("index");
        }
    }
}
