using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
namespace ConsoleApplication3
{
  public class program
  {
    static void Main(string[] args)
    {
      byte[] bytedata = new byte[200];
      char[] chardata = new char[200];
      try
      {
        FileStream aFile = new FileStream("E:\\pj\\sublimeWrite.cs", FileMode.Open);
        aFile.Seek(174, SeekOrigin.Begin);
        aFile.Read(bytedata, 0, 200);
      }
      catch (IOException e)
      {
        Console.WriteLine("An IO Exception has been thrown!");
        Console.WriteLine(e.ToString());
        Console.ReadKey();
        return;
      }
      Decoder d = Encoding.UTF8.GetDecoder();
      d.GetChars(bytedata, 0, bytedata.Length, chardata, 0);
      Console.WriteLine(chardata);
      Console.ReadKey();
    }
  }
}