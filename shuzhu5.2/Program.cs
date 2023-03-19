using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //for循环语句
            /*string[] friendNames = { "a", "b", "c", "d", "d" };
            Console.WriteLine($"Here are {friendNames.Length} of my friends:");
            int i;
            for (i = 0; i < friendNames.Length; i++)
            {
                Console.WriteLine(friendNames[i]);
            }
            Console.ReadKey();*/



            //foreach循环语句
            string[] friendNames = { "a", "b", "c", "d", "d" };
            Console.WriteLine($"Here are {friendNames.Length} of my friends:");
            //string i;
            foreach (string friend in friendNames)
            {
                Console.WriteLine(friend);
            }
            Console.ReadKey();
        }
    }
}
