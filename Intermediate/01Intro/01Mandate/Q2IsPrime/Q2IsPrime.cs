using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate._01Intro._01Mandate.Q2IsPrime
{
    public static class Q2IsPrime
    { 
        public static void IsPrime()
        {
            Console.WriteLine("IS PRIME");
            Console.WriteLine("---------");

            Console.WriteLine("Enter a number to check that is a prime number or not: ");
            int input = Convert.ToInt32(Console.ReadLine());

            bool result = CheckIsPrime(input);
            if (result)
                Console.WriteLine("Given number {0} is a PRIME number", input);
            else
                Console.WriteLine("Given number {0} is a NOT a prime number", input);
        }
        private static bool CheckIsPrime(int A)
        {
            int count = CountFactors(A);
            if (count == 2) return true;
            else return false;
        }

        private static int CountFactors(int A)
        {
            int count = 0;
            for(int i=1; i*i<=A; i++)
            {
                if(A % i == 0)
                {
                    if (i == A / i) count += 1;
                    else count += 2;
                }
            }
            return count;
        }
    }
}
