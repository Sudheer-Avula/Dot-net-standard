using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using standardCLB;

namespace ConsoleFrameWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 o = new Class1();
            Console.WriteLine(("the addition value is "+ o.Addition(10,20)));
            Console.ReadLine();
        }
    }
}
