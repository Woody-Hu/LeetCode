using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class IntegerReplacementClass
    {
        public int IntegerReplacement(int n)
        {
            if (n == int.MaxValue)
            {
                return 32;
            }

            if (n == 1)
            {
                return 0;
            }

            if (n%2 == 0)
            {
                return IntegerReplacement(n / 2) + 1;
            }

            var useMin = int.MaxValue;

            useMin = Math.Min(useMin, IntegerReplacement(n + 1) + 1);
            useMin = Math.Min(useMin, IntegerReplacement(n - 1) + 1);

            return useMin;

        }
    }
}
