using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Split_a_String_in_Balanced_Strings
    {
        public int BalancedStringSplit(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return 0;
            }

            var nL = 0;
            var nR = 0;
            var count = 0;
            foreach (var item in s)
            {
                if (item == 'L')
                {
                    nL++;
                }
                else
                {
                    nR++;
                }

                if (nL == nR)
                {
                    count++;
                    nL = 0;
                    nR = 0;
                }
            }

            if (nR != nL)
            {
                return 0;
            }

            return count;
        }
    }
}
