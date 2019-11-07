using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class Guest 
    {
        public DateTime Time { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Table> Tables { get; set; }
        public List<Dish> Dishes { get; set; }
        public Person Person { get; set; }
    }
}
