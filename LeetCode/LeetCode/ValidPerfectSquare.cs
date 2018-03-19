using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ValidPerfectSquare
    {
        public bool IsPerfectSquare(int num)
        {
            long x = num;

            while (x*x > num)
            {
                x = (x + num / x) >> 1;
            }

            return x * x == num;
        }
    }
}
