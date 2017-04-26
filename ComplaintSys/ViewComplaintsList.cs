using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ComplaintSys
{
    public partial class ViewComplaintsList : Form
    {
        int nRow;
        public static List<Complaint> complaints = new List<Complaint>();
        public static List<string> multiSortFields = new List<String>();
        public ViewComplaintsList()
        {
            InitializeComponent();
        }

        private void ViewComplaintsList_Load(object sender, EventArgs e)
        {
            LoadComplaintList();
            //DescriptionBlowup();
        }

        public void LoadComplaintList()
        {
            string inputStr;
            string[] complaintRecIn;
            const char DELIM = ',';
            Complaint aComplaint = new Complaint();


            //fs object
            FileStream fs = new FileStream("Complaints.csv", FileMode.Open, FileAccess.Read);

            //create object
            StreamReader reader = new StreamReader(fs);

            //lead read
            inputStr = reader.ReadLine();


            //loop
            while (inputStr != null)
            {
                complaintRecIn = inputStr.Split(DELIM);

                Complaint c = new Complaint();

                c.complaintNo = Convert.ToInt32(complaintRecIn[0]);
                c.customerID = Convert.ToInt32(complaintRecIn[1]);
                c.complaintType = complaintRecIn[2];
                c.complaintDesc = complaintRecIn[3];
                c.dateRecorded = Convert.ToDateTime(complaintRecIn[4]);
                c.dateOccurred = Convert.ToDateTime(complaintRecIn[5]);
                c.custExpectation = complaintRecIn[6];
                c.status = complaintRecIn[7];
                if (complaintRecIn[8] != "")
                {
                    c.resoultionDate = Convert.ToDateTime(complaintRecIn[8]);
                }
                c.resolutionDesc = complaintRecIn[9];


                complaints.Add(c);
                dgvComplaints.DataSource = null;
                dgvComplaints.DataSource = complaints;
                inputStr = reader.ReadLine();
            }
            reader.Close();
            fs.Close();



        }

        private void dgvComplaints_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvComplaints.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                MessageBox.Show(dgvComplaints.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            }
        }

        private void btnNextComplaints_Click(object sender, EventArgs e)
        {
            dgvComplaints.MultiSelect = false;

            if (nRow < dgvComplaints.RowCount)
            {
                dgvComplaints.Rows[nRow].Selected = false;
                dgvComplaints.Rows[++nRow].Selected = true;
            }
        }

        private void btnFirstComplaints_Click(object sender, EventArgs e)
        {
            int firstRowDisplayed = 0;
            dgvComplaints.MultiSelect = false;
            dgvComplaints.Rows[nRow].Selected = true;
            dgvComplaints.Rows[0].Selected = true;
            dgvComplaints.FirstDisplayedScrollingRowIndex = firstRowDisplayed;
        }

        private void btnPreviousComplaints_Click(object sender, EventArgs e)
        {
            if (nRow < dgvComplaints.RowCount)
            {
                dgvComplaints.Rows[nRow].Selected = false;
                dgvComplaints.Rows[--nRow].Selected = true;
            }
        }

        private void btnLastComplaints_Click(object sender, EventArgs e)
        {
            dgvComplaints.MultiSelect = false;

            dgvComplaints.Rows[49].Selected = true;
            dgvComplaints.FirstDisplayedScrollingRowIndex = dgvComplaints.RowCount - 1;
        }

        private void btnDisplaySelection_Click(object sender, EventArgs e)
        {
            //If statement for when a radio button is selected
            if (radID.Checked)
            {
                var filteredComplaints =
                    from c in complaints
                    orderby c.customerID ascending
                    select c;

                List<Complaint> filteredComplaintsList = filteredComplaints.ToList();
                dgvComplaints.DataSource = filteredComplaintsList;


            }
            if (radStatus.Checked)
            {
                var filteredComplaints =
                    from c in complaints
                    orderby c.status descending
                    select c;

                List<Complaint> filteredComplaintsList = filteredComplaints.ToList();
                dgvComplaints.DataSource = filteredComplaintsList;
            }

            if (radType.Checked)
            {
                var filteredComplaints =
                     from c in complaints
                     orderby c.complaintType descending
                     select c;

                List<Complaint> filteredComplaintsList = filteredComplaints.ToList();
                dgvComplaints.DataSource = filteredComplaintsList;
            }
        }

        
        private void chkID_CheckedChanged(object sender, EventArgs e)
        {
            if(chkID.Checked)
            {
                multiSortFields.Add("CustomerID");
            }
        }

        private void chkType_CheckedChanged(object sender, EventArgs e)
        {
            if (chkType.Checked)
            {
                multiSortFields.Add("ComplaintType");
            }
        }

        private void chkStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStatus.Checked)
            {
                multiSortFields.Add("Status");
            }
        }

        private void btnDisplaySelection2_Click(object sender, EventArgs e)
        {
            //1st: Retrieve the original list (MUST BE PRE-SORTED)
            var sortedComplaints =
                from c in complaints
                orderby c.customerID        //NOTE: must sort i here first by something
                select c;

            //2nd: Handle the 1st Sort Field - ORDERBY
            switch (multiSortFields.First())  //this picks the 1st element in the list
            {
                case "CustomerID":
                    sortedComplaints = sortedComplaints.OrderBy(c => c.customerID);
                    break;

                case "ComplaintType":
                    sortedComplaints = sortedComplaints.OrderBy(c => c.complaintType);
                    break;

                case "Status":
                    sortedComplaints = sortedComplaints.OrderBy(c => c.status);
                    break;

                
            }

            //3rd: Handle ALL ADDITIONAL Sort Fields - THENBY
                //this skips/ignores the 1st element in the list
                foreach (string fieldNm in multiSortFields.Skip(1))
            {
                switch(fieldNm)
                {
                    case "CustomerID":
                        sortedComplaints = sortedComplaints.ThenBy(c => c.customerID);
                        break;

                    case "ComplaintType":
                        sortedComplaints = sortedComplaints.ThenBy(c => c.complaintType);
                        break;

                    case "Status":
                        sortedComplaints = sortedComplaints.ThenBy(c => c.status);
                        break;
                }
            }

            List<Complaint> multiSortFieldsList = sortedComplaints.ToList();
            dgvComplaints.DataSource = multiSortFieldsList;
        }

        
    }
}
