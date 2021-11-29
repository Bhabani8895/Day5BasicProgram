using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class LeapYear
    {
        public void Year()
        {
            int year;
            Console.WriteLine("Enter a year to check wheater Leap Or Not");
            year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4) == 0)
                Console.WriteLine("{0} is a leap year");
            else if ((year % 100) == 0)
                Console.WriteLine("{0} is not a leap year");
            else
                Console.WriteLine("{0} is not a leap year");
        }
    }
}