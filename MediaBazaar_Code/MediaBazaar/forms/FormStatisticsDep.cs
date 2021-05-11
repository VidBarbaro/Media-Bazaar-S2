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
    public partial class FormStatisticsDep : Form
    {
        private EmployeeAdministration empAdmin;
        private Department d;
        public FormStatisticsDep(EmployeeAdministration empAdmin, Department d)
        {
            InitializeComponent();
            this.empAdmin = empAdmin;
            this.d = d;

            label1.Text = d.Name + " Department";

            String employees = "";
            foreach (Employee e in this.empAdmin.EmployeesFromDepartment(d.Name))
            {
                employees = employees + " " + e.Name + ",";
            }
            employees = employees.Remove(employees.Length - 1, 1);

            lblEmp.Text = employees;
            lblPersonel.Text = d.RequiredPersonel.ToString();

            chartGender.Series["Gender"].IsValueShownAsLabel = true;

            ShowCharts();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DateTime GetStartWeek()
        {
            DateTime currentDate = DateTime.Today;
            DateTime startWeek = DateTime.Today;
            if (currentDate.DayOfWeek.ToString() == "Monday")
            {
                startWeek = currentDate;
            }
            else if (currentDate.DayOfWeek.ToString() == "Tuesday")
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


        private void ShowCharts()
        {
            //gender chart
            int nrFemale = this.empAdmin.NrFemaleEmployeesDepartment(d);
            int nrMale = this.empAdmin.NrOfEmployeesPerDepartment(d.Name) - nrFemale;
            chartGender.Series["Gender"].Points.AddXY("Female", nrFemale);
            chartGender.Series["Gender"].Points.AddXY("Male", nrMale);

            //attendence chart
            foreach(Employee e in this.empAdmin.EmployeesFromDepartment(this.d.Name))
            {
                int nrShifts = this.empAdmin.NrShiftsEmployee(e, GetStartWeek());
                int nrFree = 7 - nrShifts;

                chartAttendence.Series["Present"].Points.AddXY(e.Name, nrShifts);
                chartAttendence.Series["Free"].Points.AddXY(e.Name, nrFree);
            }
        }
    }
}
