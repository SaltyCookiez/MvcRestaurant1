using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcRestaurant1.Models
{
	public class Restaurant
	{
		public int Id { get; set; }

        [Display(Name = "Restaurant Name")]
        public string Name { get; set; }

		[Display(Name = "Opening Date")]
        [DataType(DataType.Date)]
		public DateTime OpeningDate { get; set;	}
		public string Food { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
	}
}
