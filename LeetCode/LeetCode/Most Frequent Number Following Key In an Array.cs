using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Most_Frequent_Number_Following_Key_In_an_Array
    {
        public int MostFrequent(int[] nums, int key)
        {
            if (nums.Length == 0)
                return 0;

            var dic = new Dictionary<int, int>();
            int max = 0;
            int result = 0;

            for (int i = 0; i <= nums.Length - 2; i++)
            {

                if (nums[i] == key)
                {
                    dic[nums[i + 1]] = dic.ContainsKey(nums[i + 1])? dic[nums[i + 1]] + 1: 1;
                    if (max < dic[nums[i + 1]])
                    {
                        max = dic[nums[i + 1]];
                        result = nums[i + 1];
                    }
                }
            }
            return result;
        }
    }
}
