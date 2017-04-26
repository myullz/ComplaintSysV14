using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplaintSys
{
    public class Customer
    {
        public int customerID { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string prefix { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

    }
}
