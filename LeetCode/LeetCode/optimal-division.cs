using System;
using System.Text;

namespace LeetCode
{
	public class optimal_division
	{
		public string OptimalDivision(int[] nums)
		{
			var n = nums.Length;
            if (n == 1)
            {
				return nums[0].ToString();
            }
            else if (n == 2)
            {
				return $"{nums[0]}/{nums[1]}";
            }

			var stringBuilder = new StringBuilder();
			stringBuilder.Append($"{nums[0]}/({nums[1]}");
			for (int i = 2; i < n; i++)
			{
				stringBuilder.Append($"/{nums[i]}");
			}

			stringBuilder.Append(")");
			return stringBuilder.ToString();
            {

            }
		}
	}
}

