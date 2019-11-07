using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class Waiter 
    {

        public double Salary { get; set; }
        public List<Table> Tables { get; set; }
        public Person Person { get; set; }
    }
}
