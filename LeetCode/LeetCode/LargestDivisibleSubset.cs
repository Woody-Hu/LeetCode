using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class LargestDivisibleSubset
    {
        public IList<int> LargestDivisibleSubset(int[] nums)
        {
            List<int> tempnums = nums.OrderBy(k => k).ToList();

            int length = nums.Length;

            int[] useCount = new int[length];

            int[] preIndex = new int[length];

            int max = int.MinValue;

            int useIndex = -1;

            for (int i = 0; i < length; i++)
            {
                useCount[i] = 1;
                preIndex[i] = -1;

                for (int j = i -1; j >=0; j--)
                {
                    if (tempnums[i] % tempnums[j] == 0)
                    {
                        if (useCount[j] + 1 > useCount[i])
                        {
                            useCount[i] = useCount[j] + 1;
                            preIndex[i] = j;
                        }
                    }
                }

                if (useCount[i] > max)
                {
                    max = useCount[i];
                    useIndex = i;
                }
            }

            List<int> returnValue = new List<int>();
            while (useIndex != -1)
            {
                returnValue.Add(tempnums[useIndex]);
                useIndex = preIndex[useIndex];
            }

            return returnValue;
        }
    }
}
