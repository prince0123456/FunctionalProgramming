using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    internal class Harmonic
    {
        public double Harmonicnum(int endNo)
        {
            double sum = 0;
            for (int i = 1; i <= endNo; i++)
            {                                                            // for loop iterates to the given number
                sum = sum + ((double)1 / i);                            // gives series like 1+1/2+1/3+1/4+1/5+1/6+1/7........
            }

            return sum;                                                 // return total value of series
        }
    }
}
