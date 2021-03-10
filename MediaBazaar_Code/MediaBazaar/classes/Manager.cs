using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.classes
{
    public class Manager : User
    {
        //instance variables
        protected String position;

        //constructor 
        public Manager(string name, int age, string email, Gender gender, string phoneNumber, string address, double hourlyWage, double hoursWorked) : base(name, age, email, gender, phoneNumber, address, hourlyWage, hoursWorked)
        {

        }

        //properties
        public String Position
        {
            get; 
            private set;
        }

        //methods
        public override String ToString()
        {
            return $"Manager: ID - {id}, Name - {name}, Email - {email}, Phonenumber - {phoneNumber}";
        }
    }
}
