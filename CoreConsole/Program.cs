using System;
using standardCLB;

namespace CoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 o = new Class1();
            Console.WriteLine(("the addition value is " + o.Addition(10, 20)));
            Console.ReadLine();
        }
    }
}
