using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class Person
    {
        public string Name { get; set; }
        public Waiter Waiter { get; set; }
        public Guest Guest { get; set; }

    }
}
