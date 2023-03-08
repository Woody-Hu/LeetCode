using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class replace_elements_in_an_array
	{
        public int[] ArrayChange(int[] nums, int[][] operations)
        {
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                dic[nums[i]] = i;
            }

            foreach (var item in operations)
            {
                var index = dic[item[0]];
                nums[index] = item[1];
                dic.Remove(item[0]);
                dic[item[1]] = index;
            }

            return nums;
        }
    }
}

