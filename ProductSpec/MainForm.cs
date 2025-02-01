using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProductSpec
{
    public partial class MainForm : Form
    {


        private List<Product> products;
        Product chosenProduct = new Product();

        private List<string> based = new List<string> { };
        //List<string> based = product.Codes.ToList();
        private List<string> plus = new List<string> { "ABC", "CDF", "CDF", "CDF", "BY" };
        private List<string> extra = new List<string> { };

        public MainForm()
        {
            InitializeComponent();


            


            string workFolder = "Prices/";
            string priceList = "stock.csv";
            string fullPath = workFolder + priceList;

            products = ReadProductsFromFile(fullPath);
            chosenProduct = products[0].Clone();
            based = chosenProduct.Codes;



            //////
            productDropdown.Items.Clear();

            foreach (Product product in products)
            {
                productDropdown.Items.Add(product.Name);
            }

            // select the first item if the list isn't empty
            if (productDropdown.Items.Count > 0)
            {
                productDropdown.SelectedIndex = 0;
                label1.Text = "Price: " + products[0].Cost.ToString();
            }

            productDropdown.SelectedIndexChanged += ProductDropdown_SelectedIndexChanged;
            /////////


            ////////////
            Console.WriteLine($"\n\nSelected Product: {chosenProduct.Name}, Cost: {chosenProduct.Cost}");
            OutputLists();
            //listAllProducts();



            

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void OutputLists()
        {
            Console.Write("Base list: ");
            foreach (string item in based) { Console.Write(item + " "); }

            Console.Write("\nPlus list: ");
            foreach (string item in plus) { Console.Write(item + " "); }

            
            foreach (string plusCode in plus)
            {
                if (!based.Remove(plusCode)) //whole algorithm boils down to this
                    extra.Add(plusCode);
            }
            Console.Write("\nList of PLUS codes not in BASE: ");

            foreach (var extraCode in extra)
            {
                Console.Write(extraCode + " ");
            }
        }

        private void listAllProducts()
        {
            Console.WriteLine("\n\nProducts list: ");


            foreach (var singleProduct in products)
            {
                Console.WriteLine($"ID: {singleProduct.ID}, Name: {singleProduct.Name}, Cost: {singleProduct.Cost}");
                Console.Write("Codes: ");
                foreach (var code in singleProduct.Codes)
                {
                    Console.Write(code + " ");
                }

                Console.WriteLine("\nDescription: " + singleProduct.Description);
                Console.WriteLine();
            }
        }

        private void ProductDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            // Ensure a valid selection
            if (productDropdown.SelectedIndex >= 0)
            {
                string selectedProductName = productDropdown.SelectedItem.ToString();
                extra.Clear();

                // Find the selected product in the list
                Product selectedProduct = products.FirstOrDefault(p => p.Name == selectedProductName);

                if (selectedProduct != null)
                {
                    // Update label or any other UI elements based on selection
                    label1.Text = $"Price: {selectedProduct.Cost.ToString("0.00")}";

                    //do stuff
                    chosenProduct = selectedProduct.Clone();
                    Console.WriteLine($"\n\nSelected Product: {chosenProduct.Name}, Cost: {chosenProduct.Cost}");
                    based = chosenProduct.Codes;
                    OutputLists();
                }
            }
        }



        ///////////////////////
        
        /////////////////
        /// 
        /// 
        /// 
       
        //////////////
        /*
        public static void ReadProductFromFile(string filename, Product product) //obsolete
        {        
            string[] lines = File.ReadAllLines(filename);        
            foreach (var line in lines)
            {            
                string[] fields = line.Split(';');
                if (fields.Length == 4)
                {                
                    string[] tagArray = fields[0].Split(',');
                    product.Codes = new List<string>(tagArray.Select(t => t.Trim()));
                    product.Name = fields[1].Trim();
                    product.Cost = float.Parse(fields[2].Trim(), CultureInfo.InvariantCulture);
                    product.Description = fields[3].Trim();
                }
            }
        }
        */
        ////////////////////////////




        public static List<Product> ReadProductsFromFile(string filename)
        {
            List<Product> products = new List<Product>();

            string[] lines = File.ReadAllLines(filename);

            foreach (var line in lines)
            {
                string[] fields = line.Split(';');

                if (fields.Length == 5) // Now expecting 5 fields including ID
                {
                    Product product = new Product();

                    // Parse ID from the first field
                    product.ID = fields[0].Trim();

                    string[] tagArray = fields[1].Split(',');
                    product.Codes = new List<string>(tagArray.Select(t => t.Trim()));

                    product.Name = fields[2].Trim();
                    product.Cost = float.Parse(fields[3].Trim(), CultureInfo.InvariantCulture);
                    product.Description = fields[4].Trim();


                    // Parse cost safely
                    if (float.TryParse(fields[3].Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out float cost))
                    {
                        product.Cost = cost;
                    }
                    else
                    {
                        // Handle error, e.g., log it or set a default value
                        Console.WriteLine($"Failed to parse cost for product {product.ID}: {fields[3].Trim()}. Setting cost to 0.");
                        product.Cost = 0f; // Default value for invalid costs
                    }

                    products.Add(product);
                }
                else
                {
                    Console.WriteLine($"Skipping malformed line: {line}");
                }
            }

            return products;
        }



    }

    
    //////////////
    


    //////////////
    public class Product
    {
        public string ID { get; set; }
        public List<string> Codes { get; set; }
        public string Name { get; set; }
        public float Cost { get; set; }
        public string Description { get; set; }

        public Product()
        {
            Codes = new List<string>();
        }
        public Product(string id, List<string> codes, string name, float cost, string description)
        {
            ID = id;
            Codes = codes;
            Name = name;
            Cost = cost;
            Description = description;
        }


        public Product Clone()
        {
            return new Product
            {
                ID = this.ID,
                Codes = new List<string>(this.Codes), // New list for independence
                Name = this.Name,
                Cost = this.Cost,
                Description = this.Description
            };
        }


    }


}
