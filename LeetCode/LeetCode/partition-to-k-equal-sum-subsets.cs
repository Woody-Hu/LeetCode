using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class partition_to_k_equal_sum_subsets
    {
        private Dictionary<int, bool> _usedRes = new Dictionary<int, bool>();

        public bool CanPartitionKSubsets(int[] nums, int k)
        {
            var sum = 0;
            foreach (var item in nums)
            {
                sum += item;
            }

            var request = sum / k;
            if (sum % k != 0)
            {
                return false;
            }

            var used = 0;
            var bucket = new int[k + 1];
            return TryBucket(nums, bucket, request, k, 0, used);
        }

        private bool TryBucket(int[] nums, int[] bucket, int request, int k, int index, int used)
        {
            if (k == 0)
            {
                return true;
            }

            if (bucket[k] == request)
            {
                var nextRes = TryBucket(nums, bucket, request, k - 1, 0, used);
                _usedRes[used] = nextRes;
                return nextRes;
            }

            if (_usedRes.TryGetValue(used, out var exist))
            {
                return exist;
            }

            for (int i = index; i < nums.Length; i++)
            {
                if (((used >> i) & 1) == 1)
                {
                    continue;
                }

                if (bucket[k] + nums[i] > request)
                {
                    continue;
                }

                bucket[k] += nums[i];
                used |= 1 << i;
                if (TryBucket(nums, bucket, request, k, index + 1, used))
                {
                    return true;
                }

                bucket[k] -= nums[i];
                used ^= 1 << i;
            }

            return false;
        }
    }
}
