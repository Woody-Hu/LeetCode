using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class XOR_Operation_in_an_Array
    {
        public int XorOperation(int n, int start)
        {
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                var num = start + 2 * (i);
                res = res ^ num;
            }
            return res;
        }
    }
}
