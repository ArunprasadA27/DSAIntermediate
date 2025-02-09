using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate._01Intro._02Additional.Q1PerfectNumber
{
    public static class Q1PerfectNumber
    {
        public static void PerfectNumber()
        {
            Console.WriteLine("Check for Perfect Number");
            Console.WriteLine("------------------------");

            Console.WriteLine("Enter the number to check for Perfect Number:");
            var input = Convert.ToInt32(Console.ReadLine());

            var output = CheckForPerfectNumberOptimised(input);
            Console.WriteLine(output == 1 ? "Given number {0} is a PERFECT Number" : "Given number {0} is NOT a PERFECT Number", input);

        }


        private static int CheckForPerfectNumberOptimised(int A)
        {
            int sum = 1;

            for(int i=2; i*i<=A; i++) 
            { 
                if(A%i == 0)
                {
                    sum += i;
                    if (i != A / i) 
                        sum += A / i;
                }
            }
            return (sum == A && A != 1) ? 1 : 0;
        }

        // Below is a generic code. 
        private static int CheckForPerfectNumber(int A)
        {
            int sum = 0;

            for(int i=1; i<A; i++)
            {
                if(A%i == 0)
                {
                    sum += i;
                }
            }
            if (sum == A)
                return 1;
            return 0;
        }

    }
}
