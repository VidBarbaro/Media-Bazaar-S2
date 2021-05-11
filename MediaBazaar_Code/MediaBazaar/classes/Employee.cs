using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.classes
{
    public class Employee : User
    {
        //instance variables
        String department;


        //constructor 
        public Employee(int id, string name, string password, string email, String gender, string phoneNumber, string address, double hourlyWage, double hoursWorked, DateTime birthDate, int holidayDays, int sickDays, String department) 
            : base(id, name, password, email, gender, phoneNumber, address, hourlyWage, hoursWorked, birthDate, holidayDays, sickDays)
        {
            this.department = department;
        }

        //properties
        public String Department { get { return this.department; } set { this.department = value; } }
    }
}
