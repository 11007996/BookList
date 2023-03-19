using static System.Console;
using static System.Convert;

namespace enumleixing
{
    enum orientation : byte
    {
        north = 45,
        south,
        east,
        west
    }
    class Program
    {
        static void Main(string[] args)
        {
            orientation myDirection = orientation.east;
            byte byteDirection = (byte)myDirection;
            WriteLine($"myDirection = {byteDirection}");
            ReadKey();
        }
    }
}
