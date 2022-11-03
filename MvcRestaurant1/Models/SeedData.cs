using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcRestaurant1.Data;
using System;
using System.Linq;

namespace MvcRestaurant1.Models
{
	public class SeedData
	{
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcRestaurant1Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcRestaurant1Context>>()))
            {
                // Look for any movies.
                if (context.Restaurant.Any())
                {
                    return;   // DB has been seeded
                }

                context.Restaurant.AddRange(
                    new Restaurant
                    {
                        Name = "Hell Kitchen",
                        OpeningDate = DateTime.Parse("2023-2-12"),
                        Food = "Scallops",
                        Price = 30M
                    },

                    new Restaurant
                    {
                        Name = "CHI",
                        OpeningDate = DateTime.Parse("2023-3-13"),
                        Food = "Chicken Curry",
                        Price = 6.50M
                    },

                    new Restaurant
                    {
                        Name = "Kaks Kokapoissi",
                        OpeningDate = DateTime.Parse("2023-2-23"),
                        Food = "Burgerrito",
                        Price = 8.50M
                    },

                    new Restaurant
                    {
                        Name = "Ay Caramba",
                        OpeningDate = DateTime.Parse("2023-4-15"),
                        Food = "Taco",
                        Price = 8.50M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
