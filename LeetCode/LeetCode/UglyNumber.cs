using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class UglyNumber
    {
        int[] factors = { 2, 3, 5 };
        public bool IsUgly(int num)
        {
            if (1 == num)
            {
                return true;
            }

            if (0 == num)
            {
                return false;
            }

            foreach (int i in factors)
            {
                if (0 == num % i)
                {
                    return IsUgly(num / i);
                }
            }

            return false;
        }
    }
}
