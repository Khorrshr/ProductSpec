using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of strings
        List<string> based = new List<string> { "XY", "CDF", "CDF", "XYZ" };
        List<string> plus = new List<string> { "ABC", "CDF", "CDF", "CDF", "BY" };
        List<string> extra = new List<string> { };

        Console.WriteLine("Base list:");
        foreach (string item in based) { Console.Write(item + ", "); }

        Console.WriteLine("\nPlus list:");
        foreach (string item in plus) { Console.Write(item + ", "); }

        Console.WriteLine("\n");
        
        foreach (string plusCode in plus)
        {
            if (!based.Remove(plusCode))
                extra.Add(plusCode);
        }
        Console.WriteLine("List of PLUS codes not in BASE:");
        foreach (var extraCode in extra) { Console.Write(extraCode + " "); }
        
    }
}