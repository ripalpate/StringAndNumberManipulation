using System;

namespace StringAndNumberManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter random number separating by comma");
            var y = Console.ReadLine();
            Console.WriteLine("Do you want to multiply or square the number?");
            var selectedChoice = Console.ReadLine().ToLower();
            var seperateString = y.Split(',');
            var x = 1;
            if (selectedChoice == "multiply")
            {
                foreach (var z in seperateString)
                {
                    x = x * Convert.ToInt32(z);
                }
                Console.WriteLine("Multiplication is: {0}", x);
                Console.ReadLine();
            }
            else if (selectedChoice == "square") {
                var convertingString = " ";
                foreach (var z in seperateString) {
                    var c = 1;
                    c = c * Convert.ToInt16(z);
                    var square = Math.Pow(c, 2);
                    convertingString += square.ToString()+",";
                }
                Console.WriteLine("Squares are: {0}", convertingString.TrimEnd(','));
                Console.ReadLine();
            }
        }
    }
}
