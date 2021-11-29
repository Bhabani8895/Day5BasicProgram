using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class HarmonicNumber
    {
        public void Harmonic()
        {
            int n;
            double s = 0;
            Console.WriteLine("Enter the number of terms ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                s = Convert.ToDouble(s + Convert.ToDouble(1 / i));
                Console.WriteLine("1/" + i);
            }
            Console.WriteLine("Sum of nth terms=" + s);
        }
    }
}