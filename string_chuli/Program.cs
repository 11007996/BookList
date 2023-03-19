using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_chuli
{
  class Program
  {
    static void Main(string[] args)
    {
      #region
      /*string myString = "A string";
      char myChar = myString[3];
      Console.WriteLine($"{myChar}");
      char[] myChars = myString.ToCharArray();
      const  char x = 's';
      myChars[5] = (char)x;
      string strings="";
      foreach(char zimu in myChars)
      {
        strings += zimu;
      }
      Console.WriteLine($"{strings}");
      Console.ReadKey();*/
      #endregion
      #region
      Console.WriteLine("请输入一串字符串：");
      string strings = Console.ReadLine();
      string zifu ="";
      //char[] myChar = strings.ToCharArray();
      //int i;
      for ( int i=strings.Length-1;i>=0;i--)
      {
        zifu += strings[i];
      }
      Console.WriteLine($"{zifu}");
      Console.ReadKey();
      #endregion
    }
  }
}
