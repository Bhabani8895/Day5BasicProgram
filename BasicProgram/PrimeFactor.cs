using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class PrimeFactor
    {
        public void Prime()
        {
            Console.WriteLine("\t(((((Program to find prime factors)))))");
            Console.WriteLine("Enter any number:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; n > 1; i++)
            {
                if (n % i == 0)
                {
                    int x = 0;
                    while (n % i == 0)
                    {
                        n = n / i;
                        x++;
                    }
                    Console.WriteLine(i + " is a prime factor " + x + " times!");
                }

            }
        }
    }
}