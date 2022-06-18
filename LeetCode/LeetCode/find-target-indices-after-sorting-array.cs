using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class find_target_indices_after_sorting_array
	{
		public IList<int> TargetIndices(int[] nums, int target)
		{
			Array.Sort(nums);
			var res = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > target)
                {
					break;
                }
                else if (nums[i] == target)
                {
					res.Add(i);
                }
            }

			return res;
		}
	}
}

