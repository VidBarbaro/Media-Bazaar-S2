using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.classes
{
    class Product
    {
        //instance variables

        private int id;
        private static int idSeeder = 1;
        private String name;
        private ProductCategory category;
        private double price;
        private String description;
        private String distributor;
        private String emailDistributor;
        private String phoneNumberDistributor;

        //properties

        public int Id { get { return this.id; } }
        public String Name { get { return this.name; }private set { this.name = value; } }
        public ProductCategory Category { get { return this.category; } private set { this.category = value; } }
        public double Price { get { return this.price; } private set { this.price = value; } }
        public String Description { get { return this.description; }private set { this.description = value; } }
        public String Distributor { get { return this.distributor; } private set { this.distributor = value; } }


        //constructors
        public Product(String name, ProductCategory category, double price, String description, String distributor, String emailDistributor, String phoneNrDistributor)
        {
            this.id = id;
            idSeeder++;
            this.name = name;
            this.category = category;
            this.price = price;
            this.description = description;
            this.distributor = distributor;
            this.emailDistributor = emailDistributor;
            this.phoneNumberDistributor = phoneNrDistributor;
        }

        public Product(String name, ProductCategory category, double price, String distributor, String emailDistributor, String phoneNrDistributor)
        {
            this.id = idSeeder;
            idSeeder++;
            this.name = name;
            this.category = category;
            this.price = price;
            this.distributor = distributor;
            this.emailDistributor = emailDistributor;
            this.phoneNumberDistributor = phoneNrDistributor;
            this.description = "No description";
        }

        //methods

        public override string ToString()
        {
            return $"{id},{name},{category},{price},{description},{distributor},{emailDistributor},{phoneNumberDistributor}";
        }

    }
}
