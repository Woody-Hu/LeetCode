using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Moving_Stones_Until_Consecutive
    {
        public int[] NumMovesStones(int a, int b, int c)
        {
            var min = Math.Min(a, Math.Min(b, c));
            var max = Math.Max(a, Math.Max(b, c));
            var mid = a + b + c - max - min;
            var res = new int[2];
            res[1] = max - min - 2;
            if (max-min > 2)
            {
                if (max - mid <=2 || mid - min <= 2)
                {
                    res[0] = 1;
                }
                else
                {
                    res[0] = 2;
                }
            }

            return res;
        }
    }
}
