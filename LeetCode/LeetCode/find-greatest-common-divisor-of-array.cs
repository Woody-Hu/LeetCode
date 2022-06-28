using System;
namespace LeetCode
{
    public class find_greatest_common_divisor_of_array
    {
        public int FindGCD(int[] nums)
        {
            Array.Sort(nums);
            int min = nums[0];
            int max = nums[nums.Length - 1];
            int ans = 1;
            for (int i = min; i >= 1; i--)
            {
                if (min % i == 0 && max % i == 0)
                {
                    ans = i;
                    break;
                }
            }

            return ans;
        }
    }
}
