using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class find_the_minimum_number_of_fibonacci_numbers_whose_sum_is_k
    {
        public int FindMinFibonacciNumbers(int k)
        {
            var f = new List<int>();
            f.Add(1);
            var first = 1;
            var second = 1;
            while (first + second <= k)
            {
                var temp = first + second;
                f.Add(temp);
                first = second;
                second = temp;
            }

            var res = 0;
            for (int i = f.Count -1; i >= 0 && k >0; i--)
            {
                var temp = f[i];
                if (k >= temp)
                {
                    k -= temp;
                    res++;
                }
            }

            return res;
        }
    }
}
