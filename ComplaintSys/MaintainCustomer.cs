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
    public partial class MaintainCustomer : Form
    {
        int nRow;
        //string customer;
        public MaintainCustomer()
        {
            InitializeComponent();
        }
        public static List<Customer> customer = new List<Customer>();

        private void MaintainCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomerList();

            nRow = dgvMaintain.CurrentCell.RowIndex;

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
                dgvMaintain.DataSource = null;
                dgvMaintain.DataSource = customer;
                inputStr = reader.ReadLine();
            }
            reader.Close();
            fs.Close();


        }



        

        private void dgvMaintain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMaintain.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string CustID = dgvMaintain.SelectedRows[0].Cells[0].Value + string.Empty;
                string LastName = dgvMaintain.SelectedRows[0].Cells[1].Value + string.Empty;
                string FirstName = dgvMaintain.SelectedRows[0].Cells[2].Value + string.Empty;
                string Prefix = dgvMaintain.SelectedRows[0].Cells[3].Value + string.Empty;
                string Gender = dgvMaintain.SelectedRows[0].Cells[4].Value + string.Empty;
                string Address = dgvMaintain.SelectedRows[0].Cells[5].Value + string.Empty;
                string City = dgvMaintain.SelectedRows[0].Cells[6].Value + string.Empty;
                string State = dgvMaintain.SelectedRows[0].Cells[7].Value + string.Empty;
                string Zip = dgvMaintain.SelectedRows[0].Cells[8].Value + string.Empty;
                string Phone = dgvMaintain.SelectedRows[0].Cells[9].Value + string.Empty;
                string Email = dgvMaintain.SelectedRows[0].Cells[10].Value + string.Empty;

                txtCustID.Text = CustID;

                txtLastName.Text = LastName;

                txtFirstName.Text = FirstName;

                txtPrefix.Text = Prefix;

                txtGender.Text = Gender;

                txtAddress.Text = Address;

                txtCity.Text = City;

                txtState.Text = State;

                txtZip.Text = Zip;

                txtPhone.Text = Phone;
                txtEmail.Text = Email;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
