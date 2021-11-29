
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class ThreeNumComparison
    {
        public void GreatestNum()
        {
            Console.WriteLine("((((Program To check Greatest Amongst three Numbers))))");
            Console.WriteLine("Enter first number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first number:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first number:");
            int c = Convert.ToInt32(Console.ReadLine());
            if ((a > b) && (a > c))
                Console.WriteLine(a + " is greatest");
            else if (b > c)
                Console.WriteLine(b + " is greatest");
            else
                Console.WriteLine(c + " is greatest");
        }
    }
}