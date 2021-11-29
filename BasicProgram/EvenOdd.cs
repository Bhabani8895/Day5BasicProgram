using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class EvenOdd
    {
        public void EvenOrOdd()
        {
            Console.WriteLine("Enter any number:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                System.Console.WriteLine(number + " is even!!");
            }
            else
            {
                System.Console.WriteLine(number + " is odd!!");
            }

        }
    }
}