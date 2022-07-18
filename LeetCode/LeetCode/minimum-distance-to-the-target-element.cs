using System;
namespace LeetCode
{
	public class minimum_distance_to_the_target_element
	{
        public int GetMinDistance(int[] nums, int target, int start)
        {
            var res = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] ==  target)
                {
                    res = Math.Min(res, Math.Abs(i - start));
                }
            }

            return res;
        }
    }
}

