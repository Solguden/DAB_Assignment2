using DAB_Assignment2.Models.Relations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAB_Assignment2.Models
{
    public class Waiter 
    {

        public string WaiterId { get; set; }

        public double Salary { get; set; }
        public List<WaiterTable> WaiterTables { get; set; }
        public Person Person { get; set; }
    }
}
