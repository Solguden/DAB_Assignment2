using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAB_Assignment2.Models.Relations
{
    public class RestaurantDish
    {
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

        public int DishId { get; set; }
        public Dish Dish { get; set; }
    }
}
