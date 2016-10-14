using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBHelper
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public ProductType Type { get; set; }
    }
}
