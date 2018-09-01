using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class BeautifulArrangementII
    {
        public int[] ConstructArray(int n, int k)
        {
            int[] returnValue = new int[n];

            for (int i = 0,start = 1, end = n; start <= end; i++)
            {
                returnValue[i] = k > 1 ? (k-- % 2 != 0 ? start++ : end--) : start++;
            }

            return returnValue;
        }
    }
}
