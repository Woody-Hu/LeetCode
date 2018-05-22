using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class PartitionLabels
    {
        public IList<int> PartitionLabels(string S)
        {
            List<int> returnValue = new List<int>();

            int[] useLastIndexArray = new int[26];

            for (int i = 0; i < S.Length; i++)
            {
                useLastIndexArray[S[i] - 'a'] = i;
            }

            int useStartIndex = 0;
            int useLastIndex = 0;

            for (int i = 0; i < S.Length; i++)
            {
                useLastIndex = Math.Max(useLastIndex, useLastIndexArray[S[i] - 'a']);
                if (i == useLastIndex)
                {
                    returnValue.Add(useLastIndex - useStartIndex + 1);

                    useStartIndex = useLastIndex + 1;
                }
            }

            return returnValue;

        }
    }
}
