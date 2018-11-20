using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class DIStringMatch
    {
        public int[] DiStringMatch(string S)
        {
            int[] returnValue = new int[S.Length + 1];

            int lowTag = 0;
            int highTag = S.Length;
            int useSum = 0;
            int useIndex = 0;

            foreach (var oneChar in S)
            {
                if (oneChar == 'I')
                {
                    returnValue[useIndex] = lowTag++;
                }
                else
                {
                    returnValue[useIndex] = highTag--;
                }

                useSum += returnValue[useIndex];
                useIndex++;
            }

            int n = S.Length+1;

            returnValue[useIndex] = (n * (n - 1)) / 2 - useSum;

            return returnValue;
        }
    }
}
