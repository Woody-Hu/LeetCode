using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class distinct_numbers_in_each_subarray
    {
        public int[] DistinctNumbers(int[] nums, int k)
        {
            var res = new int[nums.Length - k + 1];
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < k; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], 0);
                }

                dic[nums[i]]++;
            }

            res[0] = dic.Count;
            for (int j = 1; j <= nums.Length - k; j++)
            {
                var removedIndex = j - 1;
                var addedIndex = j + k - 1;
                var removedValue = nums[removedIndex];
                dic[removedValue]--;
                if (dic[removedValue] <= 0)
                {
                    dic.Remove(removedValue);
                }

                if (!dic.ContainsKey(nums[addedIndex]))
                {
                    dic.Add(nums[addedIndex], 0);
                }

                dic[nums[addedIndex]]++;
                res[j] = dic.Count;
            }

            return res;
        }
    }
}
