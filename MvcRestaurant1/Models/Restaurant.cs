using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcRestaurant1.Models
{
	public class Restaurant
	{
		public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Restaurant Name")]
        [Required]
        public string Name { get; set; }

		[Display(Name = "Opening Date")]
        [DataType(DataType.Date)]
		public DateTime OpeningDate { get; set;	}
		public string Food { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Required]
        public string Rating { get; set; }
    }
}
