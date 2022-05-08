using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElnurJUAN.Areas.Manage.ViewModels;
using ElnurJUAN.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElnurJUAN.Areas.Manage.Controllers
{
    [Area("manage")]
    public class AccountController : Controller
    {
        private readonly JuanContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(JuanContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        //LOGIN ADMIN ACTION
        public IActionResult Login()
        {
            return View();
        }
        //LOGIN ADMIN POST ACTION
        [HttpPost]
        public async Task<IActionResult> Login(AdminLoginViewModel loginVM)
        {
            if (!ModelState.IsValid)
                return View();

           AppUser admin = await _userManager.Users.FirstOrDefaultAsync(x=>x.UserName == loginVM.UserName && x.IsAdmin);

            if (admin == null)
            {
                ModelState.AddModelError("", "username or password is incorrect");
                return View(); 
            }

            var result = await _signInManager.PasswordSignInAsync(admin, loginVM.Password, loginVM.IsPersistent, false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "username or password is incorrect");
                return View();
            }

            return RedirectToAction("index", "dashboard");
        }
        //LOGOUT ACTION
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("login", "account");
        }
        //TEST
        //public async Task<IActionResult> test()
        //{
        //    AppUser appUser = new AppUser
        //    {
        //        FullName = "Super Admin",
        //        UserName = "Elnuradmin",
        //        Email = "superadmin@gmail.com"
        //    };

        //    var result = await _userManager.CreateAsync(appUser, "Admin123");

        //    return Ok(result.Errors);
        //}
        //public async Task<IActionResult> Test()
        //{
        //    var result2 = await _roleManager.CreateAsync(new IdentityRole("Member"));
        //    var result3 = await _roleManager.CreateAsync(new IdentityRole("SuperAdmin"));
        //    var result1 = await _roleManager.CreateAsync(new IdentityRole("Creator"));
        //    var result4 = await _roleManager.CreateAsync(new IdentityRole("Editor"));
        //    var result5 = await _roleManager.CreateAsync(new IdentityRole("Reader"));
        //    var result6 = await _roleManager.CreateAsync(new IdentityRole("SuperAdmin"));

        //    AppUser admin = await _userManager.FindByNameAsync("Elnuradmin");

        //    var result = await _userManager.AddToRoleAsync(admin, "SuperAdmin");

        //    return Ok();
        //}
    }
}
