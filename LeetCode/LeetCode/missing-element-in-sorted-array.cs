using System;
namespace LeetCode
{
	public class missing_element_in_sorted_array
	{
		private int MissingCount(int index, int[] nums)
		{
			return nums[index] - nums[0] - index;
		}

		public int MissingElement(int[] nums, int k)
		{
			var last = MissingCount(nums.Length - 1, nums);
            if (last < k)
            {
				return nums[nums.Length - 1] + k - MissingCount(nums.Length - 1, nums);
            }

			var left = 0;
			var right = nums.Length - 1;
            while (left < right)
            {
				var mid = (left + right) / 2;
				if (k > MissingCount(mid, nums))
				{
					left = mid + 1;
				}
				else
				{
					right = mid;
				}
            }

			return nums[left - 1] + k - MissingCount(left - 1, nums);
		}
	}
}

