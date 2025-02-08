using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate.CountFactors
{
    public static class Q1CountFactors
    {
        public static void CountFactors2()
        {
            Console.WriteLine("Count Factors 2");
            Console.WriteLine("---------------");
            
            Console.Write("Enter a number to find its factors : ");
            int input = Convert.ToInt32(Console.ReadLine());
            
            int result = CountFactors(input);
            Console.Write("Number of factors of {0} is: {1}", input, result);
        }

        private static int CountFactors(int A) 
        {
            int count = 0;

            for(int i=1; i * i <= A; i++)
            {
                if( A % i == 0)
                {
                    if(i == A / i)
                    {
                        count = count + 1;
                    } 
                    else
                    {
                        count = count + 2; 
                    }
                }
            }
            return count;
        }
    }
}
