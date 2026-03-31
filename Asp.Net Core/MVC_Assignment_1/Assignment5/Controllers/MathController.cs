using Microsoft.AspNetCore.Mvc;

namespace Assignment5.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Add(int a, int b)
        {
            return Content($"Sum= {5 + 6}");
        }
        public IActionResult Multiply(int a, int b)
        {
            return Content($"Multiply= {2 * 5}");
        }
    }
}