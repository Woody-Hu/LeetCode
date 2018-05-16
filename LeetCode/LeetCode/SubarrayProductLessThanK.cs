using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class SubarrayProductLessThanK
    {
        public int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            if (0 == k)
            {
                return 0;
            }

            int useSumValue = 1;

            int useCount = 0;

            int useStartIndex = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                useSumValue = useSumValue * nums[j];

                while (useStartIndex <= j && useSumValue >= k)
                {
                    useSumValue = useSumValue / nums[useStartIndex++];
                }

                useCount += j - useStartIndex + 1;
            }

            return useCount;
        }
    }
}
