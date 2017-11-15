using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SeattlePetNanny.Models;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SeattlePetNanny.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
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
                var user = new ApplicationUser { UserName = rvm.Email, Email = rvm.Email, Phone = rvm.Phone };
                var result = await _userManager.CreateAsync(user, rvm.Password);

                if (result.Succeeded)
                {
                    //// adding an Owner claim to each registered user
                    //// user will need the Owner claim to access thier profile
                    //List<Claim> Claims = new List<Claim>();
                    //Claim accountTypeClaim = new Claim(ClaimTypes.Role, "Owner", ClaimValueTypes.String);
                    //Claims.Add(accountTypeClaim);

                    //var addClaims = await _userManager.AddClaimsAsync(user, Claims);

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
    }
}
