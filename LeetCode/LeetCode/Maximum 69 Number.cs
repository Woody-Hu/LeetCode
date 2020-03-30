using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Maximum_69_Number
    {
        public int Maximum69Number(int num)
        {
            var temp = num;
            var max = num;
            var multi = 1;
            while (temp > 0)
            {
                if (temp % 10 == 6)
                {
                    var updated = num;
                    updated -= 6 * multi;
                    updated += 9 * multi;
                    max = Math.Max(updated, max);
                }
                temp /= 10;
                multi *= 10;
            }
            return max;
        }
    }
}
