using DAB_Assignment2.Models.Relations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DAB_Assignment2.Models
{
    public class Dish
    {
        [Required]
        public string DishId { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string DishName { get; set; }

        public List<RestaurantDish> RestaurantDishes { get; set; }
        public List<GuestDish> GuestDishes { get; set; }
        public Review Review { get; set; }
    }
}
