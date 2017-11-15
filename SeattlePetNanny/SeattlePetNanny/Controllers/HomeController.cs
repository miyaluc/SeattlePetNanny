﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;



namespace SeattlePetNanny.Controllers
{
    public class HomeController : Controller
    {

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Rates()
        {
            return View();
        }
    }
}
