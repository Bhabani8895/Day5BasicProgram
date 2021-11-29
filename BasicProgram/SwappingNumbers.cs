using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class SwappingNumbers

    {
        public void swap()
        {
            int a, b, c;
            Console.WriteLine("Enter the value of a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Values before Swap");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            c = a;
            a = b;
            b = c;
            Console.WriteLine("Values after Swap");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
        }
    }
}