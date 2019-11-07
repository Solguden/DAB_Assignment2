using DAB_Assignment2.Models.Relations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DAB_Assignment2.Models
{
    public class Waiter 
    {
        [Required]
        public string WaiterId { get; set; }
        [Required]
        public double Salary { get; set; }
        public List<WaiterTable> WaiterTables { get; set; }
        public Person Person { get; set; }
    }
}
