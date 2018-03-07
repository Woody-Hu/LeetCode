using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class FirstMissingPositive
    {
        public int FirstMissingPositiveMethod(int[] nums)
        {
            Array.Sort(nums);

            int useIndex = 0;


            int lastValue = 0;

            for (; useIndex < nums.Count(); useIndex++)
            {
                if (nums[useIndex] <= 0)
                {
                    continue;
                }
                else 
                {
                    if (nums[useIndex] == lastValue + 1 || nums[useIndex] == lastValue)
                    {
                        lastValue = nums[useIndex];
                    }
                    else
                    {
                        break;
                    }
                }
            }

            if (lastValue > 0 )
            {
                return lastValue + 1;
            }
            else
            {
                return 1;
            }

        }
    }
}
