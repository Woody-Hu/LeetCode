using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Prime_Arrangements
    {
        private static int MOD = (int)1e9 + 7;
        private static int[] PRIMES = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
        public int NumPrimeArrangements(int n)
        {
            int count = 0;
            foreach (var prime in PRIMES)
            {
                {
                    if (prime <= n)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return (int)((factorial(count) * factorial(n - count)) % MOD);
        }

        private long factorial(int k)
        {
            long factorial = 1;
            for (int i = 1; i <= k; i++)
            {
                factorial *= i;
                factorial %= MOD;
            }
            return factorial;
        }
    }
}
