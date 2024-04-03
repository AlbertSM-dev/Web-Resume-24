using Microsoft.AspNetCore.Mvc;

namespace Web_Resume_24.Controllers
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
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }
    }
}
