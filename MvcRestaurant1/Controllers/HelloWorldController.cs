using Microsoft.AspNetCore.Mvc;

namespace MvcRestaurant1.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "This is my default action...";
        }

        public string Welcome()
        {
            return "This is thw Welcome action method...";
        }
    }
}
