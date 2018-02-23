using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class CountBinarySubstrings
    {
        public int CountBinarySubstringsMehtod(string s)
        {
            int preCount = 0;

            int nowCount = 1;

            int returnValue = 0;

            for (int tempIndex = 0; tempIndex < s.Length - 1; tempIndex++)
            {
                if (s[tempIndex] == s[tempIndex+1])
                {
                    nowCount++;
                }
                else
                {
                    preCount = nowCount;
                    nowCount = 1;
                }

                if (preCount >= nowCount)
                {
                    returnValue++;
                }
            }

            return returnValue;
        }
    }
}
