using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBHelper
{
    public interface Menbership
    {
        int ID { get; set; }
        int getDiscount(User user);
        string Name { get; set; }
    }
}
