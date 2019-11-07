using DAB_Assignment2.Models.Relations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAB_Assignment2.Models
{
    public class Restaurant
    {
        public string RestaurantId { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }

        public List<Review> Reviews { get; set; }
        public List<RestaurantDish> RestaurantDishes { get; set; }
        //public List<Relationshipclass> 
        public List<Table> Tables { get; set; }

    }
}
