using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAB_Assignment2.Models
{
    public class Person
    {
        public string PersonId { get; set; }

        public string Name { get; set; }
        public Waiter Waiter { get; set; }
        public Guest Guest { get; set; }

    }
}
