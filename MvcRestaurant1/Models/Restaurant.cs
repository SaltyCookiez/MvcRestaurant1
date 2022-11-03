using System;
using System.ComponentModel.DataAnnotations;

namespace MvcRestaurant1.Models
{
	public class Restaurant
	{
		public int Id { get; set; }
		public string Name { get; set; }

		[DataType(DataType.Date)]
		public DateTime OpeningDate { get; set;	}
		public string Food { get; set; }
		public decimal Price { get; set; }
	}
}
