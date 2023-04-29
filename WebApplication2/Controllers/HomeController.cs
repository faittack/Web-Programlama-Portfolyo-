using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Base
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
      
        public IActionResult MainPage()
        {
          
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Project()
        {
            return View();
        }

    }
}