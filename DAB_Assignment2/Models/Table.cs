using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class Table
    {
        public int Number { get; set; }

        public List<Waiter> Waiters { get; set; }
        public Restaurant Restaurant { get; set; }
        public Guest Guest { get; set; }

    }
}
