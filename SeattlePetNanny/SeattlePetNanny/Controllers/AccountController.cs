using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SeattlePetNanny.Models;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SeattlePetNanny.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<Owner> _userManager;
        private readonly SignInManager<Owner> _signInManager;

        public AccountController(UserManager<Owner> userManager, SignInManager<Owner> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel lvm)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(lvm.Email, lvm.Password, lvm.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel rvm)
        {
            if (ModelState.IsValid)
            {
                var user = new Owner { UserName = rvm.Email, Email = rvm.Email, Location = rvm.Location, Phone = rvm.Phone };
                var result = await _userManager.CreateAsync(user, rvm.Password);

                if (result.Succeeded)
                {
                    // adding a claim to this user
                    var addRole = await _userManager.AddClaimAsync(user, (new Claim(ClaimTypes.Role, "Administrator", ClaimValueTypes.String)));

                    if (addRole.Succeeded)
                    {
                        // AWAIT and see whether user was successfully registered
                        await _signInManager.PasswordSignInAsync(rvm.Email, rvm.Password, true, lockoutOnFailure: false);
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
