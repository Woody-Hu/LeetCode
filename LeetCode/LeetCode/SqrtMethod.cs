using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class SqrtMethod
    {
        public int MySqrt(int x)
        {
            if (x == 0)
            {
                return 0;
            }

            double pre =0.0D;
            double cur = 1.0D;
            do
            {
                pre = cur;
                cur = ((double)x )/ (2 * pre) + pre / 2.0;
            } while (Math.Abs(cur - pre) > 0.00001);

            return (int)cur;

        }
    }
}
