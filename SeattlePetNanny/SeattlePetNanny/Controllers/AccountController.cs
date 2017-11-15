﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SeattlePetNanny.Data;
using SeattlePetNanny.Models;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SeattlePetNanny.Controllers
{
    public class AccountController : Controller
    {
        private readonly SeattlePetNannyContext _context1;
        private readonly ApplicationDbContext _context2;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(SeattlePetNannyContext context1, ApplicationDbContext context2, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _context1 = context1;
            _context2 = context2;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {
            return View();

        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel lvm)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(lvm.Email, lvm.Password, lvm.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    // ***************
                    // REDIRECT TO THE USER'S PROFILE ON LOGIN SUCCESS
                    return RedirectToAction("Index", "Home");
                }
            }

            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel rvm)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = rvm.Email, Email = rvm.Email, PhoneNumber = rvm.PhoneNumber };

                var result = await _userManager.CreateAsync(user, rvm.Password);
                

                if (result.Succeeded)
                {
                    // add info to secondary table if things are added successfully to the main user table

                    // get the id of the User I just added
                    int userID =_userManager.GetUserIdAsync(user).Id;
                    //int userID = _context2.Users.SingleOrDefaultAsync(u => u.UserID == id);

                    // create an owner object using the secodary info and the ID of the user I just added.
                    var owner = new Owner { UserID = userID, Location = rvm.Address, Birthday = rvm.Birthday, FirstName = rvm.FirstName, LastName = rvm.LastName };
                    // add the owner to the secondary database
                    _context1.Add(owner);
                    await _context1.SaveChangesAsync();
                    //// adding an Owner claim to each registered user
                    //// user will need the Owner claim to access thier profile
                    //List<Claim> Claims = new List<Claim>();
                    //Claim accountTypeClaim = new Claim(ClaimTypes.Role, "Owner", ClaimValueTypes.String);
                    //Claims.Add(accountTypeClaim);
                    //var addClaims = await _userManager.AddClaimsAsync(user, Claims);

                    // Adds a OwnerOnly ROLE to each person who Registers
                    // This allows then to access thier profile
                    var addRole = await _userManager.AddClaimAsync(user, (new Claim(ClaimTypes.Role, "OwnerOnly", ClaimValueTypes.String)));

                    if (addRole.Succeeded)
                        {
                        // AWAIT and see whether user was successfully registered
                        await _signInManager.PasswordSignInAsync(rvm.Email, rvm.Password, false, lockoutOnFailure: false);
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            return View();
        }

        public IActionResult AccessDenied()
        {
            return View("Forbidden");
        }

        //****$$$$$$$$$$#############@@@@@@@@@@@ <----
        // WILL NEED TO ALSO GIVE PERMISSION TO ADMINISTRATOR
        [Authorize(Roles = "OwnerOnly")]
        public IActionResult ProfilePage()
        {
            return View();
        }

        //[Authorize]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
