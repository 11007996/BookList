using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托6_6
{
  class Program
  {
    delegate double ProcessDelegate(double param1, double param2);
    static double Multiply(double param1, double param2) => param1 * param2;
    static double Divide(double param1, double param2) => param1 / param2;
    static double Sum(double param1, double param2) => param1 + param2;
    static void Main(string[] args)
    {
      ProcessDelegate process;
      Console.WriteLine("Enter 2 numbers separated with a comma:");
      string input = Console.ReadLine();
      int commaPos = input.IndexOf(",");
      double param1 = Convert.ToDouble(input.Substring(0, commaPos));
      double param2 = Convert.ToDouble(input.Substring(commaPos + 1, input.Length - commaPos - 1));
      Console.WriteLine("Enter M to multiply or D to divide or S to sum:");
      input = Console.ReadLine().ToUpper();
      /*if (input == "M")
        process = new ProcessDelegate(Multiply);
        else
        process = new ProcessDelegate(Divide);*/
      if (input == "M")
      { process = new ProcessDelegate(Multiply); }
      else
      {
        if (input == "D")
        { process = new ProcessDelegate(Divide); }
        else
        { process = new ProcessDelegate(Sum); }
      }
      Console.WriteLine($"Result:{process(param1, param2)}");
        Console.ReadKey();
      

    }
  }
}
