﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAB_Assignment2.Models.Relations
{


    public class GuestDish
    {
        public string GuestId { get; set; }
        public Guest Guest { get; set; }
        public string DishId { get; set; }
        public Dish Dish { get; set; }

    }

}