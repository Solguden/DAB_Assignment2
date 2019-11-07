using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DAB_Assignment2.Models
{
    public class Review
    {
        [Required]
        public string ReviewId { get; set; }
        [Required]
        public int Stars { get; set; }
        public string Text { get; set; }
        

        public List<Dish> Dishes { get; set; }
        public List<Guest> Guests { get; set; } 
        public Restaurant Restaurant { get; set; }

    }
}
