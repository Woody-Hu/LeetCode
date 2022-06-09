using System;
namespace LeetCode
{
    public class check_if_all_1s_are_at_least_length_k_places_away
    {
        public bool KLengthApart(int[] nums, int k)
        {
            var pre = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    if (pre != -1 && i - pre - 1 < k)
                    {
                        return false;
                    }

                    pre = i;
                }
            }

            return true;
        }
    }
}
