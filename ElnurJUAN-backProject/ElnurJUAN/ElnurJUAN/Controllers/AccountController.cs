using ElnurJUAN.Models;
using ElnurJUAN.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElnurJUAN.Controllers
{
    public class AccountController : Controller
    {
        private readonly JuanContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(JuanContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        //REGISTER ACTION
        public IActionResult Register()
        {
            return View();
        }

        
        //REGISTER  POST ACTION
        [HttpPost]
        public async Task<IActionResult> Register(MemberRegisterViewModel registerVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            AppUser member = await _userManager.FindByNameAsync(registerVM.UserName);
            if (member!=null)
            {
                ModelState.AddModelError("UserName", "username's already taken!");
                return View();
            }


            member = new AppUser
            {
                FullName = registerVM.FullName,
                UserName = registerVM.UserName,
                Email = registerVM.Email, 
                IsAdmin = false
            };
            var result = await _userManager.CreateAsync(member, registerVM.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }

            var roleResult = await _userManager.AddToRoleAsync(member, "Member");

            if (!roleResult.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }

            await _signInManager.SignInAsync(member, true);

            if (TempData["Page"].ToString()=="Register")
            {
                 TempData["Page2"] = "Checkout";
                 return RedirectToAction("checkout", "order"); 
            }

            return RedirectToAction("index", "home"); 
        }
        //LOGIN ACTION
        public IActionResult Login()
        {
            return View();
        }   
        //LOGIN POST ACTION
        [HttpPost]
        public async Task<IActionResult> Login(MemberLoginViewModel loginVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            AppUser member = await _userManager.Users.FirstOrDefaultAsync(x=>x.UserName == loginVM.UserName && !x.IsAdmin);
            if (member==null)
            {
                ModelState.AddModelError("","username or password is incorrect!");
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(member, loginVM.Password,loginVM.IsPersistent, true);
            if (result.IsLockedOut)
            {
                ModelState.AddModelError("", "too many false attempts, try again after 2 minutes ~.~");
                return View();
            }
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "username or password is incorrect!");
                return View();
            }


            return RedirectToAction("index","home");
        }

        //LOGOUT ACTION
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("index", "home");
        }
        //PROFILE ACTION
        [Authorize(Roles = "Member")]
        public async Task<IActionResult> Profile()
        {
            AppUser member = await _userManager.Users.Where(x => x.UserName == User.Identity.Name).FirstOrDefaultAsync();

            if (member==null)
            {
                return NotFound();
            }

            MemberProfileViewModel profileVM = new MemberProfileViewModel
            {
                Member = new MemberUpdateViewModel
                {
                    UserName = member.UserName,
                    FullName = member.FullName,
                    Email = member.Email,
                    Phone = member.PhoneNumber,
                    Address = member.Address,
                    City = member.City,
                    Country = member.Country
                },
                Orders = _context.Orders.Include(x => x.OrderItems).ThenInclude(x => x.Shoe).Where(x => x.AppUserId == member.Id).ToList()
            };
            return View(profileVM);
        }
        //EDIT ACTION
        [Authorize(Roles = "Member")]
        [HttpPost]
        public async Task<IActionResult> Edit(MemberUpdateViewModel memberVM)
        {
            if (memberVM==null)
            {
                return NotFound();
            }

            MemberProfileViewModel profileVM = new MemberProfileViewModel
            {
                Member = memberVM
            };

            TempData["ProfileTab"] = "Account";

            if (!ModelState.IsValid)
                return View("Profile", profileVM);

            AppUser member = await _userManager.FindByNameAsync(User.Identity.Name);

            if (member.UserName != memberVM.UserName && _userManager.Users.Any(x => x.NormalizedUserName == memberVM.UserName.ToUpper()))
            {
                ModelState.AddModelError("UserName", "username is already exists ");
                return View("Profile", profileVM);
            }

            if (member.Email != memberVM.Email && _userManager.Users.Any(x => x.NormalizedEmail == memberVM.Email.ToUpper()))
            {
                ModelState.AddModelError("Email", "email is already exists");
                return View("Profile", profileVM);
            }

            member.UserName = memberVM.UserName;
            member.FullName = memberVM.FullName;
            member.Email = memberVM.Email;
            member.Country = memberVM.Country;
            member.City = memberVM.City;
            member.Address = memberVM.Address;
            member.PhoneNumber = memberVM.Phone;

            var result = await _userManager.UpdateAsync(member);

            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View("Profile", profileVM);
            }

            if (memberVM.Password != null)
            {
                if (string.IsNullOrWhiteSpace(memberVM.CurrentPassword))
                {
                    ModelState.AddModelError("CurrentPassword", "Current Password is required!");
                    return View("Profile", profileVM);
                }
                if (string.IsNullOrWhiteSpace(memberVM.Password))
                {
                    ModelState.AddModelError("Password", "New Password is required!");
                    return View("Profile", profileVM);
                }
                 
                if (!await _userManager.CheckPasswordAsync(member, memberVM.CurrentPassword))
                {
                    ModelState.AddModelError("CurrentPassword", "Current Password is incorrect!");
                    return View("Profile", profileVM);
                }

                var passwordResult = _userManager.ChangePasswordAsync(member, memberVM.CurrentPassword, memberVM.Password);

                if (!passwordResult.Result.Succeeded)
                {
                    foreach (var item in passwordResult.Result.Errors)
                    {
                        ModelState.AddModelError("Password", item.Description);
                    }
                    return View("Profile", profileVM);
                }

            }

            await _signInManager.SignInAsync(member, false);

            TempData["Success"] = "Profile updated successfully"; 
            return RedirectToAction("profile");
        }
    }
}
