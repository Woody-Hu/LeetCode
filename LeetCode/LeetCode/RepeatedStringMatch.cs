using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class RepeatedStringMatch
    {
        public int RepeatedStringMatchMethod(string A, string B)
        {

            StringBuilder tempValue = new StringBuilder();

            

            for (int i = 1; i <= (B.Length /A.Length + 2); i++)
            {
                tempValue.Append(A);

                if (tempValue.Length < B.Length)
                {
                    continue;
                }

                if (tempValue.ToString().Contains(B))
                {
                    return i;
                }

            }

            return -1;
        }
    }
}
