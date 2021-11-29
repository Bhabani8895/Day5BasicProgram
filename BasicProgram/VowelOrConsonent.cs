using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class VowelOrConsonent
    {
        public void VowelOrCons()
        {
            char ch;
            Console.WriteLine("Enter any Character");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("Entered " + ch + " is Vowel");
            }
            else
            {
                Console.WriteLine("Entered " + ch + " is Consonant");
            }
        }
    }
}