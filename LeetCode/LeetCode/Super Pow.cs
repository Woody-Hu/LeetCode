using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Super_Pow
    {
        public int SuperPow(int a, int[] b)
        {
            int res = 1;
            for (int i = 0; i < b.Length; ++i)
            {
                res = Power(res, 10, 1337) * Power(a, b[i], 1337) % 1337;
            }
            return res;
        }

        public int Power(int a, int n, int mod)
        {
            if (n == 0) return 1;
            if (n == 1) return a % mod;
            return Power(a % mod, n / 2, mod) * Power(a % mod, n - n / 2, mod) % mod;
        }
    }
}
