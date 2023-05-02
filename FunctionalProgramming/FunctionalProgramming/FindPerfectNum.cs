using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class FindPerfectNum
    {
        public static void PerfectNum()
        {
            int n, i, sum;
            int mn, mx;
            Console.WriteLine("Find THe perfect num within a given of rang");
            Console.WriteLine("input the starting rang");
            mn=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("end rang");
            mx=Convert.ToInt32(Console.ReadLine());
            for(n=mn; n<=mx; n++)
            {
                i = 1;
                sum=0;
                while (i < n)
                {
                    if(n%i==0)
                        sum=sum+i;
                        i++;
                       
                }
                if(sum == n)
                        Console.WriteLine(n);
            }
        }
    }
}
