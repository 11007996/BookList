using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类型转换5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            short shortResult, shortVal = 4;
            int integetVal = 67;
            long longResult;
            float floatVal = 10.5F;
            double doubleRusult, doubleVal = 99.999;
            string stringResult, stringVal = "17";
            bool boolVal = true;
            Console.WriteLine("Variable Conversion Examples\n");
            doubleRusult = floatVal * shortVal;
            Console.WriteLine($"Implicit,-> doule: {floatVal} * {shortVal} -> {doubleRusult}");
            shortResult = (short)floatVal;
            Console.WriteLine($"Explicit, -> short: {floatVal} -> {shortResult}");
            stringResult = Convert.ToString(boolVal) + " " + Convert.ToString(doubleVal);
            Console.WriteLine($"Explicit, -> string: \"{boolVal}\" + \"{ doubleVal}\" -> " + $"{stringResult}");
            longResult = integetVal + Convert.ToInt64(stringVal);
            Console.WriteLine($"Mixed, -> long; {integetVal} + {stringVal} -> {longResult}");
            Console.ReadKey();
        }
    }
}
