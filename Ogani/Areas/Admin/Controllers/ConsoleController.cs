﻿using Microsoft.AspNetCore.Mvc;

namespace Ogani.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ConsoleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View();
        }
    }
}
