using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.classes
{
    public class User
    {
        //instance variables

        protected String name;
        protected int id;
        private static int idSeeder = 1;
        protected int age;
        protected Gender gender;
        protected String email;
        protected String address;
        protected String phoneNumber;
        protected double hourlyWage;
        protected double hoursWorked;

        protected String Name { get { return this.name; } }
        public int Id { get; }
        
        public String Email
        {
            get { return email; }
            set
            {
                if (value.Contains('@'))
                {
                    email = value;
                }
                else
                {
                    throw new EmailFormatException("Email incorrect");
                }
            }
        }

        public Gender Gender { get { return this.gender; } }
        public String PhoneNumber { get { return this.phoneNumber; } private set { this.phoneNumber = value; } }
        public String Address { get { return this.address; } private set { this.address = value; } }
        public double HourlyWage { get { return this.hourlyWage; } private set { this.hourlyWage = value; } }
        public double HoursWorked { get { return this.hoursWorked; } private set { this.hoursWorked = value; } }

        public User(string name, int age, string email, Gender gender, string phoneNumber, string address, double hourlyWage, double hoursWorked)
        {
            this.name = name;
            this.id = idSeeder;
            idSeeder++;
            this.age = age;
            this.email = email;
            this.gender = gender;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.hourlyWage = hourlyWage;
            this.hoursWorked = hoursWorked;
        }

        public override string ToString()
        {
            return $"{id},{name},{age},{gender},{email},{phoneNumber},{address},{hourlyWage},{hoursWorked}";
        }

    
    }
}
