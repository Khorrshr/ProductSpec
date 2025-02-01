using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of strings
        List<string> based = new List<string> { "XY", "CDF", "CDF", "XYZ" };
        List<string> plus = new List<string> { "ABC", "CDF", "CDF", "CDF", "BY" };

        // Iterate over the list using foreach
        foreach (string plusCode in plus)
        {
            Console.WriteLine(plusCode);
        }
    }
}