using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcRestaurant1.Models;

namespace MvcRestaurant1.Data
{
    public class MvcRestaurant1Context : DbContext
    {
        public MvcRestaurant1Context (DbContextOptions<MvcRestaurant1Context> options)
            : base(options)
        {
        }

        public DbSet<MvcRestaurant1.Models.Restaurant> Restaurant { get; set; }
    }
}
