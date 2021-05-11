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
    public partial class FormStatisticsCategory : Form
    {
        private ProductAdministration prodAdmin;
        private String category;
        public FormStatisticsCategory(ProductAdministration prodAdmin, String category)
        {
            InitializeComponent();
            this.prodAdmin = prodAdmin;
            this.category = category;
            label1.Text = $"{this.category} Category";
            String products = "";
            foreach(String s in this.prodAdmin.NameProductsCategory(this.category))
            {
                products = products + " " + s + ",";
            }
            products = products.Remove(products.Length - 1, 1);
            lblName.Text = products;
            lblInStock.Text = this.prodAdmin.QuantityCategory(this.category).ToString();
            lblSold.Text = this.prodAdmin.QuantitySoldCategory(this.category).ToString();
            lblProfit.Text = this.prodAdmin.ProfitCategory(this.category).ToString() + " euros";
            SeeCharts();
        }

        private void SeeCharts()
        {
            //Profit chart
            foreach(Product p in this.prodAdmin.GetProductsCategory(this.category))
            {
                double profit = p.QuantitySold * p.Price;
                chartProfitProduct.Series["Profit"].Points.AddXY(p.Name, profit);
            }

            //In stock and sold chart
            foreach (Product p in this.prodAdmin.GetProductsCategory(this.category))
            {
                int stock = p.Quantity;
                int sold = p.QuantitySold;
                chartStockSold.Series["In Stock"].Points.AddXY(p.Name, p.Quantity);
                chartStockSold.Series["Sold"].Points.AddXY(p.Name, p.QuantitySold);
            }
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
