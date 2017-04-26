using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ComplaintSys
{
    public partial class ComplaintsDashboard : Form
    {
        public ComplaintsDashboard()
        {
            InitializeComponent();
        }


        private void DisplayChartOne()
        {
            //Define the data series
            chart1.Series.Clear();
            chart1.Series.Add("Status");
            //chart1.DataSource = MainForm.complaints;
            //chart1.DataBind();

            //Format
            chart1.Series["Status"].ChartType = SeriesChartType.Pie;
            chart1.BackColor = Color.Transparent;
            chart1.ChartAreas[0].BackColor = Color.Transparent;
            chart1.Legends[0].BackColor = Color.Transparent;

            //Chart calculations
            var closed =
                from c in MainForm.complaints
                where c.status == "Closed"
                select c;

            var open =
                from c in MainForm.complaints
                where c.status == "Open"
                select c;

            var inProgress =
                from c in MainForm.complaints
                where c.status == "In Progress"
                select c;
            
            //Add the data points
            chart1.Series["Status"].Points.Add(closed.Count());
            chart1.Series["Status"].Points.Add(open.Count());
            chart1.Series["Status"].Points.Add(inProgress.Count());

            //Name the slices for the legend
            chart1.Series["Status"].Points[0].LegendText = "Closed";
            chart1.Series["Status"].Points[1].LegendText = "Open";
            chart1.Series["Status"].Points[2].LegendText = "In Progress";

            //Show default values on the slices
            chart1.Series["Status"].Points[0].IsValueShownAsLabel = true;
            chart1.Series["Status"].Points[1].IsValueShownAsLabel = true;
            chart1.Series["Status"].Points[2].IsValueShownAsLabel = true;

        }

        private void DisplayChartTwo()
        {
            //Define the data series
            chart2.Series.Clear();
            chart2.Series.Add("Complaint Types");

            //Format
            chart2.Series["Complaint Types"].ChartType = SeriesChartType.Column;
            chart2.ChartAreas[0].BackColor = Color.Transparent;
            chart2.BackColor = Color.Transparent;
            chart2.Series["Complaint Types"].Color = Color.DarkCyan;
            chart2.Legends[0].BackColor = Color.Transparent;

            //Data
            var cable = 
                from c in MainForm.complaints
                where c.complaintType == "Cable"
                select c;

            var internet =
                from c in MainForm.complaints
                where c.complaintType == "Internet"
                select c;

            var hardware =
                from c in MainForm.complaints
                where c.complaintType == "Hardware"
                select c;

            //Add data points
            chart2.Series["Complaint Types"].Points.AddXY(1, cable.Count());
            chart2.Series["Complaint Types"].Points.AddXY(2, internet.Count());
            chart2.Series["Complaint Types"].Points.AddXY(3, hardware.Count());

            var cableCount = cable.Count();
            var internetCount = internet.Count();
            var hardwareCount = hardware.Count();

            double totalComplaints = Convert.ToDouble(cableCount + internetCount + hardwareCount);

            chart2.ChartAreas[0].AxisY.Maximum = totalComplaints;

            //Provide a label instead of numerical values on x-axis
            chart2.Series["Complaint Types"].Points[0].AxisLabel = "Cable";
            chart2.Series["Complaint Types"].Points[1].AxisLabel = "Internet";
            chart2.Series["Complaint Types"].Points[2].AxisLabel = "Hardware";

            //Customize values on bars
            chart2.Series["Complaint Types"].Points[0].Label = cable.Count().ToString();
            chart2.Series["Complaint Types"].Points[1].Label = internet.Count().ToString();
            chart2.Series["Complaint Types"].Points[2].Label = hardware.Count().ToString();

            //Provide a label for the Y-axis
            chart2.ChartAreas[0].AxisY.Title = "Total Number of Complaints";


        }

        private void DisplayChartThree()
        {
            //Define the data series
            chart3.Series.Clear();
            chart3.Series.Add("Dates");

            //Format
            chart3.Series["Dates"].ChartType = SeriesChartType.Line;
            chart3.BackColor = Color.Transparent;
            chart3.ChartAreas[0].BackColor = Color.Transparent;
            chart3.Legends.Clear();
            chart3.Series["Dates"].Color = Color.Chartreuse;
            chart3.Series["Dates"].BorderWidth = 5;

            //Do any calculations
            var jan =
                 from c in MainForm.complaints
                 where c.dateOccurred.Month == 1
                 select c;
            var feb =
                from c in MainForm.complaints
                where c.dateOccurred.Month == 2
                select c;
            var mar =
                from c in MainForm.complaints
                where c.dateOccurred.Month == 3
                select c;
            var apr =
                from c in MainForm.complaints
                where c.dateOccurred.Month == 4
                select c;
            var may =
                from c in MainForm.complaints
                where c.dateOccurred.Month == 5
                select c;
            var jun =
               from c in MainForm.complaints
               where c.dateOccurred.Month == 6
               select c;
            var jul =
                from c in MainForm.complaints
                where c.dateOccurred.Month == 7
                select c;
            var aug =
                from c in MainForm.complaints
                where c.dateOccurred.Month == 8
                select c;
            var sep =
                from c in MainForm.complaints
                where c.dateOccurred.Month == 9
                select c;
            var oct =
                from c in MainForm.complaints
                where c.dateOccurred.Month == 10
                select c;
            var nov =
                from c in MainForm.complaints
                where c.dateOccurred.Month == 11
                select c;
            var dec =
                from c in MainForm.complaints
                where c.dateOccurred.Month == 12
                select c;

            //Add the data points
            chart3.Series["Dates"].Points.AddXY(1, jan.Count());
            chart3.Series["Dates"].Points.AddXY(2, feb.Count());
            chart3.Series["Dates"].Points.AddXY(3, mar.Count());
            chart3.Series["Dates"].Points.AddXY(4, apr.Count());
            chart3.Series["Dates"].Points.AddXY(5, may.Count());
            chart3.Series["Dates"].Points.AddXY(6, jun.Count());
            chart3.Series["Dates"].Points.AddXY(7, jul.Count());
            chart3.Series["Dates"].Points.AddXY(8, aug.Count());
            chart3.Series["Dates"].Points.AddXY(9, sep.Count());
            chart3.Series["Dates"].Points.AddXY(10, oct.Count());
            chart3.Series["Dates"].Points.AddXY(11, nov.Count());
            chart3.Series["Dates"].Points.AddXY(12, dec.Count());

            //Customize values on the x-axis
            chart3.Series["Dates"].Points[0].AxisLabel = "January";
            chart3.Series["Dates"].Points[1].AxisLabel = "February";
            chart3.Series["Dates"].Points[2].AxisLabel = "March";
            chart3.Series["Dates"].Points[3].AxisLabel = "April";
            chart3.Series["Dates"].Points[4].AxisLabel = "May";
            chart3.Series["Dates"].Points[5].AxisLabel = "June";
            chart3.Series["Dates"].Points[6].AxisLabel = "July";
            chart3.Series["Dates"].Points[7].AxisLabel = "August";
            chart3.Series["Dates"].Points[8].AxisLabel = "September";
            chart3.Series["Dates"].Points[9].AxisLabel = "October";
            chart3.Series["Dates"].Points[10].AxisLabel = "November";
            chart3.Series["Dates"].Points[11].AxisLabel = "December";
        }

        private void CalcTotalComplaints()
        {
            double totalComplaints = MainForm.complaints.Count;

            lblTotalComplaints.Text = totalComplaints.ToString();
        }

        private void CalcTotalCustomers()
        {
            double totalCustomers = MainForm.customer.Count;

            lblTotalCustomers.Text = totalCustomers.ToString();
        }

        
        private void ComplaintsDashboard_Load(object sender, EventArgs e)
        {
            DisplayChartOne();
            DisplayChartTwo();
            DisplayChartThree();
            CalcTotalComplaints();
            CalcTotalCustomers();
        }
    }
}
 
