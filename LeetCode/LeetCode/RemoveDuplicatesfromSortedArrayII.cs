using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class RemoveDuplicatesfromSortedArrayII
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (null == nums || 0 == nums.Length)
            {
                return 0;
            }
            int tempUseIndex = 0;
            bool tempTag = false;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[tempUseIndex] == nums[i])
                {
                    if (!tempTag)
                    {
                        tempUseIndex++;
                        nums[tempUseIndex] = nums[i];
                        tempTag = true;
                    }
                }
                else
                {
                    tempUseIndex++;
                    nums[tempUseIndex] = nums[i];
                    tempTag = false;
                }
            }

            return tempUseIndex + 1;
        }
    }
}
