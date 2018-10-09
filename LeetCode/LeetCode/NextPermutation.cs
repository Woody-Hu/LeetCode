using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class NextPermutation
    {
        public void NextPermutationMethod(int[] nums)
        {
            if (nums.Length <= 1)
            {
                return;
            }

            int i = nums.Length-1;

            for (; i >=1; i--)
            {
                if (nums[i]>nums[i-1])
                {
                    break;
                }
            }


            if (i != 0)
            {
                InnerSwap(nums, i - 1);
            }

            InnerArrange(nums, i);
        }

        private void InnerSwap(int[] nums,int inputIndex)
        {
            for (int i = nums.Length-1; i > inputIndex; i--)
            {
                if (nums[i]>nums[inputIndex])
                {
                    var tempValue = nums[i];
                    nums[i] = nums[inputIndex];
                    nums[inputIndex] = tempValue;
                    break;
                }
            }
        }

        private void InnerArrange(int[] nums,int inputIndex)
        {
            int start = inputIndex;
            int end = nums.Length - 1;
            while (start<end)
            {
                var tempValue = nums[start];
                nums[start] = nums[end];
                nums[end] = tempValue;

                start++;
                end--;
            }
        }
    }
}
