using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class LargestNumberAtLeastTwiceofOthers
    {
        public int DominantIndex(int[] nums)
        {
            int largestIndex = -1;

            int largestValue = int.MinValue;

            int nextLargestValue = int.MinValue;

            int length = nums.Length;

            for (int i = 0; i < length; i++)
            {
                if (nums[i] > largestValue)
                {
                    largestIndex = i;

                    nextLargestValue = largestValue;

                    largestValue = nums[i];
                    continue;
                }

                if (nums[i] > nextLargestValue)
                {
                    nextLargestValue = nums[i];
                }
            }

            return largestValue >= 2 * nextLargestValue ? largestIndex : -1;

        }
    }
}
