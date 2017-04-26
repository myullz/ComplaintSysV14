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
    public partial class MainForm : Form
    {
        public static List<Complaint> complaints = new List<Complaint>();
        public static List<Customer> customer = new List<Customer>();

        public MainForm()
        {

            InitializeComponent();
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

        private void LoadCustomerList()
        {
            string inputStr;
            string[] customerRecIn;
            const char DELIM = ',';
            Customer aCustomer = new Customer();


            //fs object
            FileStream fs = new FileStream("Customers.csv", FileMode.Open, FileAccess.Read);

            //create object
            StreamReader reader = new StreamReader(fs);

            //lead read
            inputStr = reader.ReadLine();


            //loop
            while (inputStr != null)
            {
                customerRecIn = inputStr.Split(DELIM);

                Customer cs = new Customer();

                cs.customerID = Convert.ToInt32(customerRecIn[0]);
                cs.lastName = (customerRecIn[1]);
                cs.firstName = customerRecIn[2];
                cs.prefix = customerRecIn[3];
                cs.gender = (customerRecIn[4]);
                cs.address = (customerRecIn[5]);
                cs.city = customerRecIn[6];
                cs.state = customerRecIn[7];

                cs.zip = Convert.ToInt32(customerRecIn[8]);
                cs.phone = customerRecIn[9];
                cs.email = customerRecIn[10];



                customer.Add(cs);

                inputStr = reader.ReadLine();
            }
            reader.Close();
            fs.Close();


        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadComplaintList();
            LoadCustomerList();
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Personal_Profile().Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new Resolution().Show();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            
    }
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
          

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new MaintainCustomer().Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new ViewComplaintsList().Show();
        }

        private void dgvComplaints_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new ComplaintsDashboard().Show();
        }
    }
    }


