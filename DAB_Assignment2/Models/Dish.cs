using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class Dish
    {
        public double Price { get; set; }
        public string Type { get; set; }
        public string DishName { get; set; }

        public List<Restaurant> Restaurants { get; set; }
        public List<Guest> Guests { get; set; }
        public Review Review { get; set; }
    }
}
