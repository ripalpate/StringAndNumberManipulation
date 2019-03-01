using System;
using System.Collections.Generic;

namespace StringAndNumberManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter random number separating by comma");
            var y = Console.ReadLine();
            var seperateString = y.Split(',');
            int x = 1;
            foreach (var z in seperateString)
            {
                x = x * Convert.ToInt32(z); 
            }
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
