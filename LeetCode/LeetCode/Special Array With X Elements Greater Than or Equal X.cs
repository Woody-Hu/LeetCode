using System;
namespace LeetCode
{
    public class Special_Array_With_X_Elements_Greater_Than_or_Equal_X
    {
        public Special_Array_With_X_Elements_Greater_Than_or_Equal_X()
        {
        }

        public int SpecialArray(int[] nums)
        {
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0 && nums[i] >= nums.Length) return nums.Length;

                if (nums[i] >= nums.Length - i && nums.Length - i > nums[i - 1]) return nums.Length - i;

            }
            return -1;
        }
    }
}
