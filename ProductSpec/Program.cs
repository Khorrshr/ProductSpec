using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {        
        List<string> based = new List<string> { "ABC", "XY", "CDF", "CDF", "XYZ" };
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