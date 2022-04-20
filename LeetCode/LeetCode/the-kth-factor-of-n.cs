using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class the_kth_factor_of_n
    {
        public int KthFactor(int n, int k)
        {
            var list = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    list.Add(i);
                }
            }

            if (k - 1 > list.Count -1)
            {
                return -1;
            }

            return list[k - 1];
        }
    }
}
