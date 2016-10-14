using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBHelper
{
    public class Vehicle
    {
        public string Plate { get; set; }
        public int Year { get; set; }
        public string Image { get; set; }
        public Driver Driver{ get; set; }
    }
}
