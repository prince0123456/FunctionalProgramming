using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    internal class FilpCoin
    {
        public void Flip(int noOfTimes)
        {
            int tails = 0, heads = 0;                                                   // initialization of input
            Random random = new Random();                                               // random object made here
            for (int i = 1; i <= noOfTimes; i++)
            {                                                                       //// it iterates for loop and check heads and tails upto given number of time.
                if (random.NextDouble() < 0.5)
                {                                                                      // random function gives random posibilities to toss heads and tails
                    tails++;                                // increment tail count
                }
                else
                {
                    heads++;                                 // increment head count
                }
            }

            Console.Write("tails percentage=");
            Console.WriteLine((double)tails / noOfTimes * 100);                     // calculate percentage of tails
            Console.Write("heads percentage=");
            Console.WriteLine((double)heads / noOfTimes * 100);                      // // calculate percentage of heads
        }
    }
}
