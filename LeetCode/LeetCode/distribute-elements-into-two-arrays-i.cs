using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class distribute_elements_into_two_arrays_i
	{
        public int[] ResultArray(int[] nums)
        {
            var n = nums.Length;
            var a = new List<int>();
            var b = new List<int>();
            a.Add(nums[0]);
            b.Add(nums[1]);
            for (int i = 2; i < n; i++)
            {
                if (a[a.Count - 1] > b[b.Count - 1])
                {
                    a.Add(nums[i]);
                }
                else
                {
                    b.Add(nums[i]);
                }
            }

            a.AddRange(b);

            return a.ToArray();
        }
    }
}

