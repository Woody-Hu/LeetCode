using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            int sumSize = nums.Length;

            if (0 == sumSize)
            {
                return 0;
            }

            int returnValue = 0;

            for (returnValue = 0; returnValue < sumSize; returnValue++)
            {
                if (target <= nums[returnValue])
                {
                    break;
                }
            }

            return returnValue;
        }
    }
}
