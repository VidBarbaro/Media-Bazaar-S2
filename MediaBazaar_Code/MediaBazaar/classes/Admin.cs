using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.classes
{
    class Admin : User
    {
        //constructor
        public Admin(string name, int age, string email, Gender gender, string phoneNumber, string address, double hourlyWage, double hoursWorked) : base(name, age, email, gender, phoneNumber, address, hourlyWage, hoursWorked)
        {

        }

        //Methods
        public override String ToString()
        {
            return $"Admin: ID - {id}, Name - {name}, Email - {email}, Phonenumber - {phoneNumber}";
        }
    }
}
