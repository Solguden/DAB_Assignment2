using DAB_Assignment2.Models.Relations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAB_Assignment2.Models
{
    public class Guest 
    {
        public string GuestId { get; set; }
        public DateTime Time { get; set; }
        public Review Reviews { get; set; }
        public List<Table> Tables { get; set; }
        public List<GuestDish> GuestDishes { get; set; }
        public Person Person { get; set; }
    }
}
