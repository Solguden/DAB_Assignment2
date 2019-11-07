using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class Restaurant
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }

        public List<Review> Reviews { get; set; }
        public List<Dish> Dishes { get; set; }
        //public List<Relationshipclass> 
        public List<Table> Tables { get; set; }

    }
}
