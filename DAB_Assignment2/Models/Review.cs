using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class Review
    {
        public int Stars { get; set; }
        public string Text { get; set; }
        

        public List<Dish> Dishes { get; set; }
        public List<Guest> Guests { get; set; } 
        public Restaurant Restaurant { get; set; }

    }
}
