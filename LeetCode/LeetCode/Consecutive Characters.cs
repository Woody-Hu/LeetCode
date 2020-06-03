using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class Consecutive_Characters
    {
        public int MaxPower(string s)
        {
            var res = 1;
            var count = 1;
            var current = s.First();
            for (var i = 1; i < s.Length; i++)
            {
                if (s[i] == current)
                {
                    count++;
                }
                else
                {
                    res = Math.Max(res, count);
                    count = 1;
                    current = s[i];
                }
            }

            res = Math.Max(res, count);
            return res;
        }
    }
}
