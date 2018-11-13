using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class DecodeWays
    {
        public int NumDecodings(string s)
        {
            int n = s.Length;
            if (n == 0) return 0;

            int[] cache = new int[n + 1];
            cache[n] = 1;
            cache[n - 1] = s[n - 1] != '0' ? 1 : 0;

            for (int i = n - 2; i >= 0; i--)
                if (s[i] == '0') continue;
                else cache[i] = (int.Parse(s.Substring(i, 2)) <= 26) ? cache[i + 1] + cache[i + 2] : cache[i + 1];

            return cache[0];
        }

      
    }
}
