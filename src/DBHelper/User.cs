using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBHelper
{
    public class User
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int CI_Nit { get; set; }
        public List<Phone> Phones { get; set; }
        public List<Address> Address { get; set; }
    }
}
