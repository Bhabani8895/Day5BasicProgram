using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class FlipCoin
    {
        public void Flip_coin()
        {
            Random toss = new Random();
            Console.WriteLine("\t(((((Program of Flip Coin!!)))))");
            Console.WriteLine("Enter the number of time coin must be tosssed");
            int n = Convert.ToInt32(Console.ReadLine());
            int head = 0;
            int tail = 0;
            int TotalToss = n;
            for (int i = 1; i <= n; i++)
            {
                double RandValues = Convert.ToDouble(toss.Next(0, 10));
                double Toss = RandValues / 10;
                if (Toss < 0.5)
                {
                    head++;
                }
                else
                {
                    tail++;
                }


                Console.WriteLine(Toss);
            }
            Console.WriteLine("head=" + head);
            Console.WriteLine("tail=" + tail);
            int Headpercent = (int)Math.Round((double)(100 * head) / TotalToss);
            int Tailpercent = (int)Math.Round((double)(100 * tail) / TotalToss);


            Console.WriteLine("HeadPercen=" + Headpercent);
            Console.WriteLine("TailPercen=" + Tailpercent);
        }
    }
}
