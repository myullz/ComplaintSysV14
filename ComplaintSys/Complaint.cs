using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ComplaintSys
{
    public class Complaint
    {
        public int complaintNo { get; set; }
        public int customerID { get; set; }
        public string complaintType { get; set; }
        public string complaintDesc { get; set; }
        public DateTime dateRecorded { get; set; }
        public DateTime dateOccurred { get; set; }
        public string custExpectation { get; set; }
        public string status { get; set; }
        public DateTime resoultionDate { get; set; }
        public string resolutionDesc { get; set; }
        

    }
}
