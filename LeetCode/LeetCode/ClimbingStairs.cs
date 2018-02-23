using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ClimbingStairs
    {
        public int ClimbStairs(int n)
        {
            if (0 == n)
            {
                return 0;
            }
            else if (1 == n)
            {
                return 1;
            }
            else if (0 > n)
            {
                return ClimbStairs(Math.Abs(n));
            }
            else
            {
                int[] returnValue = new int[n];
                returnValue[0] = 1;
                returnValue[1] = 2;

                for (int i = 2; i < n; i++)
                {
                    returnValue[i] = returnValue[i - 2] + returnValue[i - 1];
                }

                return returnValue[n - 1];
            }

        }
    }
}
