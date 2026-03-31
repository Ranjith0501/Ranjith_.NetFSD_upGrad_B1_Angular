using Microsoft.AspNetCore.Mvc;

namespace Assignment8.Controllers
{
    public class Demo : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = "John";
            ViewData["Age"] = 25;

            return View();
        }
    }
}
