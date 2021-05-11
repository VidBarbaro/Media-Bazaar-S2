using MediaBazaar.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar.forms
{
    public partial class FormStatistics : Form
    {
        private EmployeeAdministration empAdmin;
        private Manager managerLoggedIn;
        private ProductAdministration prodAdmin;
        public FormStatistics(EmployeeAdministration empAdmin, Manager managerLoggedIn, ProductAdministration prodAdmin)
        {
            InitializeComponent();
            this.empAdmin = empAdmin;
            this.managerLoggedIn = managerLoggedIn;
            this.prodAdmin = prodAdmin;

            chartGender.Series["Gender"].IsValueShownAsLabel = true;
            ShowCharts();

        }

        public void ShowCharts()
        {
            //hours worked chart
            List<Employee> bestHoursEmployees = this.empAdmin.GetBestEmployeesByHoursWorked();
            for (int i = 0; i < bestHoursEmployees.Count(); i++)
            {
                chartHoursWorked.Series["Hours Worked"].Points.AddXY(bestHoursEmployees[i].Name, bestHoursEmployees[i].HoursWorked);
            }
            //gender chart
            int percentMale = this.empAdmin.GetAllEmployees().Count() - this.empAdmin.NrFemaleEmployees();
            int percentFemale = this.empAdmin.NrFemaleEmployees();
            chartGender.Series["Gender"].Points.AddXY("Female", percentFemale);
            chartGender.Series["Gender"].Points.AddXY("Male", percentMale);

            //employees/department chart

            int sales = this.empAdmin.NrOfEmployeesPerDepartment("SALES");
            int warehouse = this.empAdmin.NrOfEmployeesPerDepartment("WAREHOUSE");
            int photovideo = this.empAdmin.NrOfEmployeesPerDepartment("PHOTO&VIDEO");
            int pclaptops = this.empAdmin.NrOfEmployeesPerDepartment("PC&LAPTOPS");
            int chargerscables = this.empAdmin.NrOfEmployeesPerDepartment("CHARGERS&CABLES");

            chartEmployeesDepartment.Series["Number of employees per department"].Points.AddXY("Sales", sales);
            chartEmployeesDepartment.Series["Number of employees per department"].Points.AddXY("Warehouse", warehouse);
            chartEmployeesDepartment.Series["Number of employees per department"].Points.AddXY("Photo & Video", photovideo);
            chartEmployeesDepartment.Series["Number of employees per department"].Points.AddXY("PC & Laptops", pclaptops);
            chartEmployeesDepartment.Series["Number of employees per department"].Points.AddXY("Chargers & Cables", chargerscables);

        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelFormsContent.Controls.Add(childForm);
            panelFormsContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnStatisticsEmp_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(tbIdEmployee.Text);
                Employee emp = empAdmin.GetEmployeeById(id);
                if (emp == null)
                {
                    MessageBox.Show("Sorry, there is no employee with the provided id");
                }
                else
                {
                    FormStatisticsEmployee formStatisticsEmployee = new FormStatisticsEmployee(this.empAdmin, emp);
                    openChildFormInPanel(formStatisticsEmployee);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Enter an id!");
            }
        }

    }
}
