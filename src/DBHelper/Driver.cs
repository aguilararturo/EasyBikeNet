using System.Collections.Generic;

namespace DBHelper
{
    public class Driver
    {
        public int CI { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public List<Address> Address{ get; set; }
        public string Picture { get; set; }
    }
}