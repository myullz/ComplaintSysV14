using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComplaintSys
{
    public class Innovation
    {
        public int resolutionID { get; set; }
        public int customerID { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string city { get; set; }
        public string issue { get; set; }
        public string employee { get; set; }
        public string description { get; set; }
        public string followup { get; set; }
        //public int rating { get; set; }
    }
}
