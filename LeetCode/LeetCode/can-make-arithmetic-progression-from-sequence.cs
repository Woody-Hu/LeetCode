using System;
namespace LeetCode
{
	public class can_make_arithmetic_progression_from_sequence
	{
		public bool CanMakeArithmeticProgression(int[] arr)
		{
			Array.Sort(arr);
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] * 2 != arr[i - 1] + arr[i + 1])
                {
					return false;
                }
            }

			return true;
		}
	}
}

