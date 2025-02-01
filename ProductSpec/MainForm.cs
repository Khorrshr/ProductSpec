using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProductSpec
{
    public partial class MainForm : Form
    {
        private List<Product> products;
        private string priceFilePath;

        public MainForm(string priceFile)
        {
            InitializeComponent();
            this.priceFilePath = priceFile;
            products = Program.ReadProductsFromFile(priceFilePath);
            if (products != null && products.Any())
            {
                label1.Text = products[0].Description;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
