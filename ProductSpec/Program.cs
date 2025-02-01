using System;
using System.Collections.Generic;

public class Product
{
    
    public List<string> Codes { get; set; }     
    public string Name { get; set; }
    public float Cost { get; set; }    
    public string Description { get; set; }    
    public Product()
    {
        Codes = new List<string>();
    }    
    public Product(List<string> codes, string name, float cost, string description)
    {
        Codes = codes;
        Name = name;
        Cost = cost;
        Description = description;
    }
}

class Program
{
    static void Main()
    {
        Product product = new Product();

        product.Codes = new List<string> { "ABC", "XY", "CDF", "CDF", "XYZ" };
        product.Name = "Exceptional Double CDFer";
        product.Cost = 249.95f;
        product.Description = "Hotplug your XYZ whenever you want!";


        //List<string> based = new List<string> { "ABC", "XY", "CDF", "CDF", "XYZ" };
        List<string> based = product.Codes.ToList();
        List<string> plus = new List<string> { "ABC", "CDF", "CDF", "CDF", "BY" };
        List<string> extra = new List<string> { };

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
        foreach (var extraCode in extra) { Console.Write(extraCode + " "); }
    }
}