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
    public partial class Resolution : Form
    {
        public static List<Innovation> resolution = new List<Innovation>();


        public Resolution()
        {
            InitializeComponent();
        }

        private void LoadResolution()
        {
            string inputStr;
            string[] resolutionRecIn;
            const char DELIM = ',';
            Innovation aResolution = new Innovation();


            //fs object
            FileStream fs = new FileStream("Resolution.csv", FileMode.Open, FileAccess.Read);

            //create object
            StreamReader reader = new StreamReader(fs);

            //lead read
            inputStr = reader.ReadLine();


            //loop
            while (inputStr != null)
            {
                resolutionRecIn = inputStr.Split(DELIM);

                Innovation rs = new Innovation();

                rs.resolutionID = Convert.ToInt32(resolutionRecIn[0]);
                rs.customerID = Convert.ToInt32(resolutionRecIn[1]);
                rs.lastName = resolutionRecIn[2];
                rs.firstName = resolutionRecIn[3];
                rs.city = resolutionRecIn[4];
                rs.issue = (resolutionRecIn[5]);
                rs.employee = (resolutionRecIn[6]);
                rs.description = resolutionRecIn[7];

                if (resolutionRecIn[8] != "")
                {
                    rs.followup = resolutionRecIn[8];
                }

                //if (resolutionRecIn[9] != "")
                //{
                //    rs.rating = Convert.ToInt32(resolutionRecIn[9]);
                //}


                resolution.Add(rs);
                dgvResolution.DataSource = null;
                dgvResolution.DataSource = resolution;
                inputStr = reader.ReadLine();
            }
            reader.Close();
            fs.Close();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           

        }

        private void Resolution_Load(object sender, EventArgs e)
        {
            LoadResolution();
        }
    }
}
