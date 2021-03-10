using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar.classes
{
    class ProductAdministration
    {
        //instance variables
        private String name;
        List<Product> products;

        //constructors
        public ProductAdministration(String name)
        {
            this.name = name;
            this.products = new List<Product>();
        }
        //methods
        public Product GetProductById(int id)
        {
            foreach (Product p in this.products)
            {
                if (p.Id == id)
                { return p; }
            }
            return null;
        }

        public Product GetProductByName(String name)
        {
            foreach (Product p in this.products)
            {
                if (p.Name == name)
                { return p; }
            }
            return null;
        }

        public Product GetProductByPrice(double price)
        {
            foreach (Product p in this.products)
            {
                if (p.Price == price)
                { return p; }
            }
            return null;
        }

        public bool AddProduct(Product product)
        {
            
            //TODO
        }
        public bool RemoveProduct(Product product)
        {
            //TODO
        }
        public List<Product> GetAllProducts()
        {
            return this.products;
        }

        public Product[] GetAllProductsByPrice(double price)
        {
            List<Product> temp = new List<Product>();
            foreach (Product p in this.products)
            {
                if (p.Price == price)
                {
                    temp.Add(p);
                }
            }
            return temp.ToArray();
        }

        public Product[] GetAllProductsByCategory(ProductCategory category)
        {
            List<Product> temp = new List<Product>();
            foreach (Product p in this.products)
            {
                if (p.Category == category)
                {
                    temp.Add(p);
                }
            }
            return temp.ToArray();
        }

        public Product[] GetAllProductsByDistributor(String distributor)
        {
            List<Product> temp = new List<Product>();
            foreach (Product p in this.products)
            {
                if (p.Distributor == distributor)
                {
                    temp.Add(p);
                }
            }
            return temp.ToArray();
        }

    }
}
