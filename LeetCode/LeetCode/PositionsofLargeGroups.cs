using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class PositionsofLargeGroups
    {
        public IList<IList<int>> LargeGroupPositions(string S)
        {
            List<IList<int>> returnValue = new List<IList<int>>();

            if (string.IsNullOrWhiteSpace(S))
            {
                return returnValue;
            }

            char lastChar = S[0];

            int nowUseCount = 1;

            int nowUseStartIndex = 0;

            for (int i = 1; i < S.Length; i++)
            {
                if (S[i] == lastChar)
                {
                    nowUseCount++;
                }
                else
                {
                    if (nowUseCount >= 3)
                    {
                        returnValue.Add(new List<int>() { nowUseStartIndex, i - 1 });
                    }
                    nowUseCount = 1;
                    nowUseStartIndex = i;
                }

                lastChar = S[i];
            }

            if (nowUseCount >= 3)
            {
                returnValue.Add(new List<int>() { nowUseStartIndex, S.Length - 1 });
            }

            return returnValue;
        
        }

        
    }
}
