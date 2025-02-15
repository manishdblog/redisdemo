﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationSession.Models;

namespace WebApplicationSession.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HttpContext.Session.SetString("Key", "Value");
            return View();
        }

        public IActionResult Privacy()
        {
            var value = HttpContext.Session.GetString("Key");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
