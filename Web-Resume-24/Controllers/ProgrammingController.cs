using Microsoft.AspNetCore.Mvc;

namespace Web_Resume_24.Controllers
{
    public class ProgrammingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
