using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate._01Intro._02Additional.Q2CountPrimes
{
    public static class Q2CountPrimes
    {
        public static void CountPrimes()
        {
            Console.WriteLine("Count Primes");
            Console.WriteLine("------------");

            Console.WriteLine("Enter a number to get the list of primes within that limit: ");
            var input = Convert.ToInt32(Console.ReadLine());

            var output = CountListOfPrimes(input);
            Console.WriteLine("There are {0} prime numbers within {1}", output, input);
        }

        private static int CountListOfPrimes(int A)
        {
            int sum = 0;
            for(int i=1; i<=A; i++)
            {
                sum += CheckIsPrime(i);
            }
            return sum;
        }
        private static int CheckIsPrime(int A)
        {
            int sum = 0;
            for(int i=1; i*i<=A; i++)
            {
                if(A%i == 0)
                {
                    sum += 1;
                    if(A/i != i)
                    {
                        sum += 1; 
                    }
                }
            }
            if (sum == 2)
                return 1;
            return 0;
        }
    }
}
