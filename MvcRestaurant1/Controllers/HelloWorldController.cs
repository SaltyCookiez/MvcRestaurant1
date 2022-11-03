using Microsoft.AspNetCore.Mvc;

namespace MvcRestaurant1.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Welcome()
        {
            return "This is thw Welcome action method...";
        }
    }
}
