using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaBazaar.classes;

namespace MediaBazaar.forms
{
    public partial class FormStatisticsEmployee : Form
    {
        private EmployeeAdministration empAdmin;
        private Employee employee;
        public FormStatisticsEmployee(EmployeeAdministration empAdmin, Employee employee)
        {
            InitializeComponent();
            this.empAdmin = empAdmin;
            this.employee = employee;

            label1.Text = employee.Name;
            lblEmail.Text = employee.Email;
            lblWage.Text = "€" + employee.HourlyWage.ToString();
            lblHours.Text = employee.HoursWorked.ToString() + " hours";
            lblFree.Text = (employee.HolidayDays + employee.SickDays).ToString() + " days";
            lblDep.Text = employee.Department;

            SeeCharts();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DateTime GetStartWeek()
        {
            DateTime currentDate = DateTime.Today;
            DateTime startWeek = DateTime.Today;
            if(currentDate.DayOfWeek.ToString() == "Monday")
            {
                startWeek = currentDate;
            }
            else if(currentDate.DayOfWeek.ToString() == "Tuesday")
            {
                startWeek = currentDate.AddDays(-1);
            }
            else if (currentDate.DayOfWeek.ToString() == "Wednesday")
            {
                startWeek = currentDate.AddDays(-2);
            }
            else if (currentDate.DayOfWeek.ToString() == "Thursday")
            {
                startWeek = currentDate.AddDays(-3);
            }
            else if (currentDate.DayOfWeek.ToString() == "Friday")
            {
                startWeek = currentDate.AddDays(-4);
            }
            else if (currentDate.DayOfWeek.ToString() == "Saturday")
            {
                startWeek = currentDate.AddDays(-5);
            }
            else if (currentDate.DayOfWeek.ToString() == "Sunday")
            {
                startWeek = currentDate.AddDays(-6);
            }

            return startWeek;
        }


        private void cbPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbPeriod.SelectedItem.ToString() == "Last week")
            {
                int nrShifts = this.empAdmin.NrShiftsEmployee(this.employee, GetStartWeek().AddDays(-7));
                if(nrShifts > 0) {
                    int percentageShifts = 100 / nrShifts;
                    int percentageFree = 100 - percentageShifts;
                    lblPresent.Text = percentageShifts.ToString() + "%";
                    lblFreeDays.Text = percentageFree.ToString() + "%";
                    lblWeek.Text = $"Week: {GetStartWeek().AddDays(-7).ToShortDateString()} - {GetStartWeek().AddDays(-1).ToShortDateString()}";
                }
                else
                {
                    MessageBox.Show("The selected employee has no shifts registered.");
                }
               
              
            }
            else if(cbPeriod.SelectedItem.ToString() == "Last 2 weeks")
            {
                int nrShifts1 = this.empAdmin.NrShiftsEmployee(this.employee, GetStartWeek().AddDays(-7));
                int nrShifts2 = this.empAdmin.NrShiftsEmployee(this.employee, GetStartWeek().AddDays(-14));
                int percentageShifts = 100 / (nrShifts1 + nrShifts2);
                int percentageFree = 100 - percentageShifts;
                lblPresent.Text = percentageShifts.ToString() + "%";
                lblFreeDays.Text = percentageFree.ToString() + "%";
                lblWeek.Text = $"Weeks: {GetStartWeek().AddDays(-14).ToShortDateString()} - {GetStartWeek().AddDays(-8).ToShortDateString()}, {GetStartWeek().AddDays(-7).ToShortDateString()} - {GetStartWeek().AddDays(-1).ToShortDateString()}";
            }
        }

        public void SeeCharts()
        {
            //attendence chart for the last 5 weeks

            //week 1
            DateTime start = GetStartWeek();

            int week1 = this.empAdmin.NrShiftsEmployee(this.employee, start);
            int free1 = 7 - week1;
            chartAttendence.Series["Present"].Points.AddXY($"{start.ToShortDateString()} - {start.AddDays(6).ToShortDateString()}", week1);
            chartAttendence.Series["On leave"].Points.AddXY($"{start.ToShortDateString()} - {start.AddDays(6).ToShortDateString()}", free1);

            int week2 = this.empAdmin.NrShiftsEmployee(this.employee, start.AddDays(-7));
            int free2 = 7 - week2;
            chartAttendence.Series["Present"].Points.AddXY($"{start.AddDays(-7).ToShortDateString()} - {start.AddDays(-1).ToShortDateString()}", week2);
            chartAttendence.Series["On leave"].Points.AddXY($"{start.AddDays(-7).ToShortDateString()} - {start.AddDays(-1).ToShortDateString()}", free2);

            int week3 = this.empAdmin.NrShiftsEmployee(this.employee, start.AddDays(-14));
            int free3 = 7 - week3;
            chartAttendence.Series["Present"].Points.AddXY($"{start.AddDays(-14).ToShortDateString()} - {start.AddDays(-8).ToShortDateString()}", week3);
            chartAttendence.Series["On leave"].Points.AddXY($"{start.AddDays(-14).ToShortDateString()} - {start.AddDays(-8).ToShortDateString()}", free3);

            int week4 = this.empAdmin.NrShiftsEmployee(this.employee, start.AddDays(-21));
            int free4 = 7 - week4;
            chartAttendence.Series["Present"].Points.AddXY($"{start.AddDays(-21).ToShortDateString()} - {start.AddDays(-15).ToShortDateString()}", week4);
            chartAttendence.Series["On leave"].Points.AddXY($"{start.AddDays(-21).ToShortDateString()} - {start.AddDays(-15).ToShortDateString()}", free4);

            int week5 = this.empAdmin.NrShiftsEmployee(this.employee, start.AddDays(-28));
            int free5 = 7 - week5;
            chartAttendence.Series["Present"].Points.AddXY($"{start.AddDays(-28).ToShortDateString()} - {start.AddDays(-22).ToShortDateString()}", week2);
            chartAttendence.Series["On leave"].Points.AddXY($"{start.AddDays(-28).ToShortDateString()} - {start.AddDays(-22).ToShortDateString()}", free2);
        }

    }
}
