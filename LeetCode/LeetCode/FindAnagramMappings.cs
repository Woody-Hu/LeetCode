using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class FindAnagramMappings
    {
        public class Solution
        {
            public int[] AnagramMappings(int[] A, int[] B)
            {
                int useCount = A.Length;
                int[] returnValue = new int[useCount];

                Dictionary<int, int> tempdic = new Dictionary<int, int>();


                int tempIndex = 0;
                foreach (var oneValue in B)
                {
                    tempdic[oneValue] = tempIndex;
                    tempIndex++;
                }

                for (int t = 0; t < useCount; t++)
                {
                    returnValue[t] = tempdic[A[t]];
                }

                return returnValue;
            }
        }
    }
}
