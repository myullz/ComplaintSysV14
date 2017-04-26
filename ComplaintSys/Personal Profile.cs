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
    public partial class Personal_Profile : Form
    {
        DataSet ds = new DataSet();
        int nRow;
        public static List<string> multiSortFields = new List<String>();

        public static List<Customer> customer = new List<Customer>();
        public Personal_Profile()
        {
            InitializeComponent();
        }

        private void Personal_Profile_Load(object sender, EventArgs e)
        {
            LoadCustomerList();

            nRow = dgvCustomer.CurrentCell.RowIndex;


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
                dgvCustomer.DataSource = null;
                dgvCustomer.DataSource = customer;
                inputStr = reader.ReadLine();
            }
            reader.Close();
            fs.Close();


        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            int firstRowDisplayed = 0;
            dgvCustomer.MultiSelect = false;
            dgvCustomer.Rows[nRow].Selected = true;
            dgvCustomer.Rows[0].Selected = true;
            dgvCustomer.FirstDisplayedScrollingRowIndex = firstRowDisplayed;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dgvCustomer.MultiSelect = false;

            if (nRow < dgvCustomer.RowCount)
            {
                dgvCustomer.Rows[nRow].Selected = false;
                dgvCustomer.Rows[++nRow].Selected = true;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (nRow < dgvCustomer.RowCount && nRow > 0)
            {
                dgvCustomer.Rows[nRow].Selected = false;
                dgvCustomer.Rows[--nRow].Selected = true;
            }

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            dgvCustomer.MultiSelect = false;

            dgvCustomer.Rows[99].Selected = true;
            dgvCustomer.FirstDisplayedScrollingRowIndex = dgvCustomer.RowCount - 1;
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }



        private void btnDisplaySelCheckboxes_Click(object sender, EventArgs e)
        {
            



            if (radCustID.Checked)
            {
                var sortedCustomers =
                from cs in customer
                orderby cs.customerID ascending
                select cs;



                List<Customer> sortedCustomersList = sortedCustomers.ToList();
                dgvCustomer.DataSource = sortedCustomersList;
            }
            else if (radLastName.Checked)
            {
                var sortedCustomers =
                from cs in customer
                where cs.lastName.StartsWith("A")
                orderby cs.lastName ascending
                select cs;


                List<Customer> sortedCustomersList = sortedCustomers.ToList();
                dgvCustomer.DataSource = sortedCustomersList;
            }

            else if (radState.Checked)
            {
                var sortedCustomers =
                from cs in customer
                where cs.state == "TX"
                orderby cs.state ascending
                select cs;


                List<Customer> sortedCustomersList = sortedCustomers.ToList();
                dgvCustomer.DataSource = sortedCustomersList;
            }

            else
            {
                var sortedCustomers =
                    from cs in customer
                    where cs.firstName.StartsWith("A")
                    orderby cs.firstName ascending
                    select cs;


                List<Customer> sortedCustomersList = sortedCustomers.ToList();
                dgvCustomer.DataSource = sortedCustomersList;

            }


        }

        private void btnDisplaySelection2_Click(object sender, EventArgs e)
        {
           
            //1st: Retrieve the original list (MUST BE PRE-SORTED)
            var sortedCustomers =
                from cs in customer
                orderby cs.customerID       //NOTE: must sort i here first by something
                select cs;

            //2nd: Handle the 1st Sort Field - ORDERBY
            switch (multiSortFields.First())  //this picks the 1st element in the list
            {
                case "CustomerID":
                    sortedCustomers = sortedCustomers.OrderBy(cs => cs.customerID);
                    break;

                case "LastName":
                    sortedCustomers = sortedCustomers.OrderBy(cs => cs.lastName);
                    break;

                case "FirstName":
                    sortedCustomers = sortedCustomers.OrderBy(cs => cs.firstName);
                    break;

                case "State":
                    sortedCustomers = sortedCustomers.OrderBy(cs => cs.state);
                    break;


            }

            //3rd: Handle ALL ADDITIONAL Sort Fields - THENBY
            //this skips/ignores the 1st element in the list
            foreach (string fieldNm in multiSortFields.Skip(1))
            {
                switch (fieldNm)
                {
                    case "CustomerID":
                        sortedCustomers = sortedCustomers.ThenBy(cs => cs.customerID);
                        break;

                    case "LastName":
                        sortedCustomers = sortedCustomers.ThenBy(cs => cs.lastName);
                        break;

                    case "FirstName":
                        sortedCustomers = sortedCustomers.ThenBy(cs => cs.firstName);
                        break;

                    case "State":
                        sortedCustomers = sortedCustomers.ThenBy(cs => cs.state);
                        break;
                }
               
            }

           

           




            List<Customer> multiSortFieldsList = sortedCustomers.ToList();
            dgvCustomer.DataSource = multiSortFieldsList;
        }

        private void chkID_CheckedChanged(object sender, EventArgs e)
        {
            if (chkID.Checked)
            {
                multiSortFields.Add("customerID");
            }

        }

        private void chkLn_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLn.Checked)
            {
                multiSortFields.Add("lastName");
            }

        }

        private void chkFn_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFn.Checked)
            {
                multiSortFields.Add("firstName");
            }

        }

        private void chkState_CheckedChanged(object sender, EventArgs e)
        {
            if (chkState.Checked)
            {
                multiSortFields.Add("state");
            }

        }

        

    }
}

