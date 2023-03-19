using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fenzhi
{
    class Program
    {
        static void Main(string[] args)
        {
            string comparison;
            Console.WriteLine("Enter a number:");
            Double var1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another number:");
            Double var2 = Convert.ToDouble(Console.ReadLine());
            if (var1 < var2)
                comparison = "less than ";
            else
            {
                if (var1 == var2)
                    comparison = "eqia to ";
                else
                    comparison = "greater than ";
            }
            Console.WriteLine($"The first number is {comparison}" + $"the second number.");
            Console.ReadKey();
        }
    }
}
