using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class distinct_prime_factors_of_product_of_array
    {
        public int DistinctPrimeFactors(int[] nums)
        {
            var primeSet = new HashSet<int>();
            var primeFactorSet = new HashSet<int>();
            foreach (var n in nums)
            {
                if (primeFactorSet.Contains(n))
                {
                    continue;
                }
                if (IsPrime(n, primeSet))
                {
                    primeFactorSet.Add(n);
                }

                var temp = n;
                for (int i = 2; i <= Math.Sqrt(temp); i++)
                {
                    if (IsPrime(i, primeSet))
                    {
                        while (temp % i == 0)
                        {
                            primeFactorSet.Add(i);
                            temp /= i;
                            if (IsPrime(temp, primeSet))
                            {
                                primeFactorSet.Add(temp);
                                break;
                            }
                        }
                    }
                }

            }

            return primeFactorSet.Count;
        }

        private bool IsPrime(int n, HashSet<int> primeSet)
        {
            if (primeSet.Contains(n))
            {
                return true;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            primeSet.Add(n);
            return true;
        }
    }
}
