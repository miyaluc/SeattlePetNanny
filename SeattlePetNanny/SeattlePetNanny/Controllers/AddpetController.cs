using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SeattlePetNanny.Data;
using SeattlePetNanny.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeattlePetNanny.Controllers
{
    public class AddpetController : Controller
    {
        private readonly SeattlePetNannyContext _context1;
        private readonly UserManager<ApplicationUser> _userManager;

        public AddpetController(SeattlePetNannyContext context1, UserManager<ApplicationUser> userManager)
        {
            _context1 = context1;
            _userManager = userManager;
        }
        // gets the current user
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        [Authorize(Roles = "OwnerOnly")]
        [HttpGet]
        public IActionResult Modal()
        {
            return View();
        }

        [Authorize(Roles = "OwnerOnly")]
        [HttpPost]
        public async Task<IActionResult> Modal(DogViewModel dvm)
        {
            //var user = new ApplicationUser { UserName = rvm.Email, Email = rvm.Email, PhoneNumber = rvm.PhoneNumber };

            if (ModelState.IsValid)
            {
                // add info to secondary table if things are added successfully to the main user table
                // get the id of the User I just added
                //int userID = _userManager.GetUserIdAsync(user).Id;


                var user = _userManager.GetUserId(User);
                var owner = await _context1.Owner.FirstOrDefaultAsync(m => m.UserID == user);

                //var user = GetCurrentUserAsync();
                //var owner = await _context1.Owner.FirstOrDefaultAsync(m => m.UserID == user.Id);

                /*OwnerId = owner.OwnerID,*/


                // add the owner to the secondary database then save database
                var userDog = new Dog { Name = dvm.Name, Breed = dvm.Breed, Temperment = dvm.Temperment };
                _context1.Add(userDog);
                //owner.Dogs.Add(userDog)
                await _context1.SaveChangesAsync();

                return RedirectToAction("ProfilePage", "Account");
            }
            return View();
        }
    }
}
