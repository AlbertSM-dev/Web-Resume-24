﻿using Microsoft.AspNetCore.Mvc;

namespace Web_Resume_24.wwwroot.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
