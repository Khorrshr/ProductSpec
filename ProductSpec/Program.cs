using ProductSpec;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


//old stuff from back when it was a Console App initially
//not Windows Form app like rn



namespace ProductSpec
{
    public class Program
    {
        



        /////////////////////////////
        [STAThread]
        static void Main()
        {
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            



            //Product product = new Product();
            //ReadProductFromFile(priceFile, product);


            /*
            product.Codes = new List<string> { "ABC", "XY", "CDF", "CDF", "XYZ" };
            product.Name = "Exceptional Double CDFer";
            product.Cost = 249.95f;
            product.Description = "Hotplug your XYZ whenever you want!";
            */

            /*
            //List<string> based = new List<string> { "ABC", "XY", "CDF", "CDF", "XYZ" };
            List<string> based = product.Codes.ToList();
            List<string> plus = new List<string> { "ABC", "CDF", "CDF", "CDF", "BY" };
            List<string> extra = new List<string> { };

            Console.Write("Old version: ");
            Console.Write("\nBase list: ");
            foreach (string item in based) { Console.Write(item + " "); }

            Console.Write("\nPlus list: ");
            foreach (string item in plus) { Console.Write(item + " "); }

            foreach (string plusCode in plus)
            {
                if (!based.Remove(plusCode)) //whole algorithm boils down to this
                    extra.Add(plusCode);
            }
            Console.Write("\nList of PLUS codes not in BASE: ");
            foreach (var extraCode in extra) { Console.Write(extraCode + " "); }
            */

            ////////////
            
        }
    }

}