using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBHelper
{
    public class Stock
    {
        public int ID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public DateTime ActiveDate { get; set; }
    }
}
