using System;
using static System.String;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchyuju
{
  class Program
  {
    static void Main(string[] args)
    {
      const string myName = "bejamin";
      const string niceName = "andrea";
      const string sillyName = "ploppy";
      string name;
      Console.WriteLine("What is your name?");
      name = Console.ReadLine();
      switch (name.ToLower())
      {
        case myName:
          Console.WriteLine("You have the same name as me!");
          break;
        case niceName:
          Console.WriteLine("My,wht a nice name you have!");
          break;
        case sillyName:
          Console.WriteLine("What's a very silly name.");
          break;
      }
      Console.WriteLine($"Hello {name}！");
      Console.ReadKey();
    }
  }
}