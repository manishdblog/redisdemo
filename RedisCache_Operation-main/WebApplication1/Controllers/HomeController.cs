using Microsoft.AspNetCore.Mvc;
using RedisCacheHelper;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRedisCacheService _cacheService;
        public HomeController(ILogger<HomeController> logger, IRedisCacheService cacheService)
        {
            _logger = logger;
            _cacheService = cacheService;
        }

        public IActionResult Index()
        {
            // Set a value in the cache
            _cacheService.SetAsync("myKey", "myValue", TimeSpan.FromMinutes(10));
            return View();
        }

        public IActionResult Privacy()
        {
            var value = _cacheService.GetAsync<string>("myKey").Result;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
