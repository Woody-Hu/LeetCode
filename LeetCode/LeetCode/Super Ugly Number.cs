using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Super_Ugly_Number
    {
        public int NthSuperUglyNumber(int n, int[] primes)
        {
            if (primes == null || primes.Length == 0)
            {
                return 0;
            }

            var dpArray = new int[n];
            dpArray[0] = 1;
            var dic = new Dictionary<int,int>();
            foreach (var onePrime in primes)
            {
                dic.Add(onePrime, 0);
            }

            for (int i = 1; i < n; i++)
            {
                var min = int.MaxValue;
                foreach (var onePrime in primes)
                {
                    min = Math.Min(min, onePrime * dpArray[dic[onePrime]]);
                }

                dpArray[i] = min;

                foreach (var onePrime in primes)
                {
                    if (min == onePrime * dpArray[dic[onePrime]])
                    {
                        dic[onePrime]++;
                    }
                }
            }

            return dpArray[n-1];

        }
    }
}
