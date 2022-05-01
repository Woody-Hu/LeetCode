using System;
namespace LeetCode
{
	public class fixed_point
	{
		public int FixedPoint(int[] arr)
		{
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == i)
                {
                    return i;
                }
            }

            return -1;
		}
	}
}

