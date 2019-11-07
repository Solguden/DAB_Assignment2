using DAB_Assignment2.Models.Relations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DAB_Assignment2.Models
{
    public class Restaurant
    {
        [Required]
        public string RestaurantId { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Type { get; set; }

        public List<Review> Reviews { get; set; }
        public List<RestaurantDish> RestaurantDishes { get; set; }
        //public List<Relationshipclass> 
        public List<Table> Tables { get; set; }

    }
}
