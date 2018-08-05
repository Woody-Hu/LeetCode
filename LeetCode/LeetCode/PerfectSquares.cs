using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class PerfectSquares
    {
        public int NumSquares(int n)
        {
            int[] returnValue = new int[n + 1];

            returnValue[1] = 1;

            for (int i = 2; i < n + 1; i++)
            {
                int tempMinValue = int.MaxValue;

                int j = 1;

                while (j*j <= i)
                {
                    tempMinValue = Math.Min(tempMinValue, returnValue[i - j * j]);
                    j++;
                }

                returnValue[i] = tempMinValue + 1;
            }

            return returnValue[n];
        }
    }
}
