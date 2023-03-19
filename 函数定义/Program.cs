using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 函数定义
{
  class Program
  {
    /*#region
    static int MaxValue(int[] intArray)
    {
      int MaxVal = intArray[0];
      for (int i = 1; i < intArray.Length; i++)
      {
        if (intArray[i] > MaxVal)
          MaxVal = intArray[i];
      }
      return MaxVal;
    }
    static void Main(string[] args)
    {
      int[] myArray = { 1, 8, 3, 6, 2, 15, 12, 3, 0, 2 };
      int maxVau = MaxValue(myArray);
      Console.WriteLine($"The maximun value in myArray is {maxVau}");
      Console.ReadKey();
    }
    #endregion*/
    /* #region
     static int SumVals(params int[] vals)
     {
       int sum = 0;
       foreach(int val in vals)
       {
         sum += val;
       }
       return sum;
     }
     static void Main(string[] args)
     {
       //int[] suzu = { 1, 5, 2, 9, 8 };
       int Sum = SumVals(1, 5, 2, 9, 8);
       //int Sum = SumVals(1,5,2,9,8);
       Console.WriteLine($"Summed Value = {Sum}");
       Console.ReadKey();
     }
     #endregion*/
    #region
    /* private static (int max, int min, double average)
     GetMaxMin(IEnumerable<int> numbers)
   {
     return (Enumerable.Max(numbers), Enumerable.Min(numbers), Enumerable.Average(numbers));
   }*/

    //求和函数
    /*static int AvergerVals(params int[] vals)
    {
      int sum = 0;
      int averger =0;
      foreach (int val in vals)
      {
        sum += val;
        averger = sum / vals.Length;
      }
      return averger;
    }

    //求最大值
    static int MaxValue(int[] intArray)
    {
      int MaxVal = intArray[0];
      for (int i = 1; i < intArray.Length; i++)
      {
        if (intArray[i] > MaxVal)
          MaxVal = intArray[i];
      }
      return MaxVal;
    }

    //求最小值函数
    static int MinValue(int[] intArray)
    {
      int MinVal = intArray[0];
      for (int i = 1; i < intArray.Length; i++)
      {
        if (intArray[i] < MinVal)
          MinVal = intArray[i];
      }
      return MinVal;
    }

    static void Main(string[] args)
    {
      int[] numbers = { 1, 2, 3, 4, 5, 6 };   //求数组的最大值、最小值、平均值

      int min = MinValue(numbers);
      int max = MaxValue(numbers);
      int averger = AvergerVals(numbers); 
     // var result = GetMaxMin(numbers);
      Console.WriteLine($"Max number is {max},\n" +
        $"Min number is {min},\n" +
        $"Average is {averger}.");
      Console.ReadKey();
    }*/
    #endregion
    /*#region
    static void Write()
    {
      string myString = "String defined in Write()";
      Console.WriteLine($"Now in Write()");
      Console.WriteLine($"myString = {myString}");
    }
    static void Main(string[] srgs)
    {
      string myString = "String defined in Main()";
      Write();
      Console.WriteLine("\nNow in Main()");
      Console.WriteLine($"myString = {myString}");
      Console.ReadKey();
    }
    #endregion*/
    /*#region
    static void ShowDouble(ref int val)
    {
      val *= 2;
      Console.WriteLine($"val doubled = {val}");
    }
    static void Main(string[] args)
    {
      int val = 5;
      Console.WriteLine($"val = {val}");
      ShowDouble(ref val);
      Console.WriteLine($"val = {val}");
      Console.ReadKey();
    }
    #endregion*/
  }
} 
