﻿using Microsoft.AspNetCore.Mvc;

namespace TES_MEDICAL.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
