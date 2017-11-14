using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeattlePetNanny.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        //[Authorize(Roles = "Owner")]
        [Authorize(Policy = "OwnerOnly")]
        public IActionResult Test()
        {
            return View();
        }
    }
}
