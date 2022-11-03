using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Security.Policy;

namespace MvcRestaurant1.Models
{
    public class RestaurantFoodViewModel
    {
        public List<Restaurant> Restaurants { get; set; }
        public SelectList Foods { get; set; }
        public string RestaurantFood { get; set; }
        public string SearchString { get; set; }
    }
}
