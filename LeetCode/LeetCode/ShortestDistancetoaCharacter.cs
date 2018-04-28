using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ShortestDistancetoaCharacter
    {
        public int[] ShortestToChar(string S, char C)
        {
            int[] returnValue = new int[S.Length];

            List<int> lstUseIndex = new List<int>();

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == C)
                {
                    lstUseIndex.Add(i);
                }
            }

            if (0 == lstUseIndex.Count)
            {
                return returnValue;
            }

            int nowUseIndex = 0;

            for (int i = 0; i < S.Length; i++)
            {
                if (i > lstUseIndex[nowUseIndex] && nowUseIndex + 1 < lstUseIndex.Count && i > lstUseIndex[nowUseIndex] +  ( lstUseIndex[nowUseIndex + 1] - lstUseIndex[nowUseIndex])/2  )
                {
                    nowUseIndex++;
                }

                returnValue[i] = Math.Abs(i - lstUseIndex[nowUseIndex]);
            }

            return returnValue;
        }
    }
}
