﻿using Microsoft.AspNetCore.Mvc;
using la_mia_pizzeria_static.Models;

namespace la_mia_pizzeria_static.Controllers
{
    public class GuestController : Controller
    {
        public IActionResult Index()
        {

            ViewData["title"] = "Guest side";
            return View();
        }
    }
}