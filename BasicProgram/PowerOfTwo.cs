using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class PowerOfTwo
    {
        public void TwoPower()
        {
            int n;
            Console.WriteLine("Enter the number of terms:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The various Terms are");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}