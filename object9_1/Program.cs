using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object9_1
{
  public abstract class MyBase { };
  internal class MyClass : MyBase { };
  public interface IMyBaseInterface { };
  internal interface IMyBaseInterface2 { };
  internal interface IMyinterface : IMyBaseInterface, IMyBaseInterface2 { };
  internal sealed class MyComplexClass : MyClass, IMyBaseInterface { };
  class Program
  {
    
    static void Main(string[] args)
    {
      MyComplexClass myobj = new MyComplexClass();
      Console.WriteLine(myobj.ToString());
      Console.ReadKey();
    }
  }
}
