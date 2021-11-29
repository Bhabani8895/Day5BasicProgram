using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class QuotientAndRemainder
    {
        public void QAndR()
        {
            Console.WriteLine("Enter Dividend");
            int Dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisor");
            int Divisor = Convert.ToInt32(Console.ReadLine());
            int Quotient = Convert.ToInt32(Dividend / Divisor);
            Console.WriteLine("Quotient=" + Quotient);
            int Remainder = Convert.ToInt32(Dividend % Divisor);
            Console.WriteLine("Remainder=" + Remainder);
        }
    }
}