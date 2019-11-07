using DAB_Assignment2.Models.Relations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAB_Assignment2.Models
{
    public class Dish
    {
        public string DishId { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }
        public string DishName { get; set; }

        public List<RestaurantDish> RestaurantDishes { get; set; }
        public List<GuestDish> GuestDishes { get; set; }
        public Review Review { get; set; }
    }
}
