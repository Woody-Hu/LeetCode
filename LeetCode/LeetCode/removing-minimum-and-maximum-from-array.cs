using System;
namespace LeetCode
{
	public class removing_minimum_and_maximum_from_array
	{
        public int MinimumDeletions(int[] nums)
        {
            var minI = 0;
            var maxI = 0;
            var min = int.MaxValue;
            var max = int.MinValue;
            var n = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                var value = nums[i];
                if (value < min)
                {
                    min = value;
                    minI = i;
                }

                if (value > max)
                {
                    max = value;
                    maxI = i;
                }
            }

            var l = Math.Min(minI, maxI);
            var r = Math.Max(minI, maxI);
            return Math.Min(r + 1, Math.Min(n - l, l + 1 + n - r));
        }
    }
}

