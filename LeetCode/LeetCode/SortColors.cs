using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class SortColors
    {
        public void SortColorsMethod(int[] nums)
        {
            int index0 = 0;
            int index2 = nums.Length - 1;

            int index = 0;

            while (index <= index2)
            {
                if (nums[index] == 0)
                {
                    nums[index] = nums[index0];
                    nums[index0] = 0;
                    index0++;
                }

                if (nums[index] == 2)
                {
                    nums[index] = nums[index2];
                    nums[index2] = 2;
                    index2--;
                    index--;
                }

                index++;
            }


        }
    }
}
