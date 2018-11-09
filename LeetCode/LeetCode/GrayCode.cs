using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class GrayCode
    {
        public IList<int> GrayCodeMethod(int n)
        {
            IList<int> returnValue = new List<int>();

            for (int i = 0; i < 1<<n; i++)
            {
                returnValue.Add(i^(i>>1));
            }

            return returnValue;
        }
    }
}
