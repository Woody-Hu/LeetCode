using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Contains_Duplicate_III
    {
        public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            if (nums == null || nums.Length <= 1 || t < 0)
            {
                return false;
            }

            if (t == 0)
            {
                return ContainsNearbyDuplicate(nums, k);
            }

            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int bucket = GetBucket(nums[i], t);

                if (dict.ContainsKey(bucket) && i - dict[bucket] <= k)
                {
                    return true;
                }

                if (dict.ContainsKey(bucket - 1) && i - dict[bucket - 1] <= k && nums[i] - nums[dict[bucket - 1]] <= t)
                {
                    return true;
                }

                if (dict.ContainsKey(bucket + 1) && i - dict[bucket + 1] <= k && nums[dict[bucket + 1]] - nums[i] <= t)
                {
                    return true;
                }

                dict[bucket] = i;
            }

            return false;
        }

        private int GetBucket(int num, int t)
        {
            return num < 0 ? (num + 1) / t - 1 : num / t;
        }

        private bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
                else
                {
                    int lastIndex = dict[nums[i]];
                    if (i - lastIndex <= k)
                    {
                        return true;
                    }
                    else
                    {
                        dict[nums[i]] = i;
                    }
                }
            }

            return false;
        }
    }
}
