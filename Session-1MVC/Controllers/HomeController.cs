using Microsoft.AspNetCore.Mvc;

namespace Session_1MVC.Controllers
{
    public class HomeController : Controller
    {

        // View : HTML Page 
        // Razor Page : HTML + C#
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AoutUs()   
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

    }
}
