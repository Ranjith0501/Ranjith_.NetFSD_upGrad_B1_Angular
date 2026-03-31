using Microsoft.AspNetCore.Mvc;

namespace Assignment9.Controllers
{
    public class DemoController : Controller
    {
       
            public IActionResult Index()
        {
            ViewData["Title"] = "Home Page";
            return View();
        }
    }
}
