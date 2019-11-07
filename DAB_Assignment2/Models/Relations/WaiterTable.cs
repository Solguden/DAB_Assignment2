using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAB_Assignment2.Models;

namespace DAB_Assignment2.Models.Relations
{
    public class WaiterTable
    {
        public int WaiterId { get; set; }
        public Waiter Waiter { get; set; }
        public int TableId { get; set; }
        public Table Table { get; set; }
    }
}
