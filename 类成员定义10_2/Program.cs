using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Console;
using System.Runtime;

namespace 类成员定义10_2
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Creating object myobj...");
      MyClass myobj = new MyClass("My object");
      Console.WriteLine("myobj created.");
      for (int i = -1; i <= 0; i++)
      {
        try
        {
          Console.WriteLine($"\nAttemption to assign {i} to myobj.Val...");
          myobj.Val = i;
          Console.WriteLine($"Value {myobj.Val}) assigned to myobj.Val.");
        }
        catch (Ecxception e)
        {
          Console.WriteLine($"Exception {e.GetType().FullName} thrown.");
          Console.WriteLine($"Message:\n"{ e.Meassage}\"");
        }
      }
      Console.WriteLine("\nOuString()...");
      Console.WriteLine(myobj.ToString());
      Console.WriteLine("myobj.ToString() Output.");
      Console.WriteLine("\nmyDoubledIntProp = 5 ...");
      Console.WriteLine($"Getting myDoubledIntProp of 5 is {myobj.myDoubledIntProp}");
      Console.ReadKey();
    }
  }
}
