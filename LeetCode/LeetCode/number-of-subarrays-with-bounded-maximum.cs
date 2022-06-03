using System;
namespace LeetCode
{
	public class number_of_subarrays_with_bounded_maximum
	{
		public int NumSubarrayBoundedMax(int[] nums, int left, int right)
		{
			return CalculateInBound(nums, right) - CalculateInBound(nums, left - 1);
		}

		private int CalculateInBound(int[] nums, int boun)
		{
			var res = 0;
			var current = 0;
            foreach (var item in nums)
            {
				if (item <= boun)
				{
					current = current + 1;
				}
				else
				{
					current = 0;
				}

				res += current;
            }

			return res;
		}
	}
}

