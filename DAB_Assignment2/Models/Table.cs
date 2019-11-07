using DAB_Assignment2.Models.Relations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace DAB_Assignment2.Models
{
    public class Table
    {
        [Required]
        public int Number { get; set; }
        [Required]
        public string TableId { get; set; }


        public List<WaiterTable> WaiterTables { get; set; }
        public Restaurant Restaurant { get; set; }
        public Guest Guest { get; set; }

    }
}
