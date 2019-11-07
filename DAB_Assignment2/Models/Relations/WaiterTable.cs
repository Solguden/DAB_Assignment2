using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAB_Assignment2.Models;

namespace DAB_Assignment2.Models.Relations
{
    public class WaiterTable
    {
        public string WaiterId { get; set; }
        public Waiter Waiter { get; set; }
        public string TableId { get; set; }
        public Table Table { get; set; }
    }
}
