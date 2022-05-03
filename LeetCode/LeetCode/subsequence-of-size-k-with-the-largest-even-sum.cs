using System;
namespace LeetCode
{
    public class subsequence_of_size_k_with_the_largest_even_sum
    {
        public long LargestEvenSum(int[] nums, int k)
        {
            Array.Sort(nums);
            Array.Reverse(nums);
            var res = 0l;
            for (int i = 0 ; i < k; i++)
            {
                res += nums[i];
            }

            if (res % 2 == 0)
            {
                return res;
            }

            var maxEven = int.MinValue;
            var maxOdd = int.MinValue;
            for (int i = k; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    maxEven = Math.Max(maxEven, nums[i]);
                }
                else
                {
                    maxOdd = Math.Max(maxOdd, nums[i]);
                }
            }

            var minEven = int.MaxValue;
            var minOdd = int.MaxValue;
            for (int i = 0; i < k; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    minEven = Math.Min(minEven, nums[i]);
                }
                else
                {
                    minOdd = Math.Min(minOdd, nums[i]);
                }
            }

            var res1 = -1l;
            var res2 = -1l;
            if (maxEven != int.MinValue && minOdd != int.MaxValue)
            {
                res1 = res + maxEven - minOdd;
            }

            if (maxOdd != int.MinValue && minEven != int.MaxValue)
            {
                res2 = res + maxOdd - minEven;
            }

            return Math.Max(res1, res2);
        }
    }
}
