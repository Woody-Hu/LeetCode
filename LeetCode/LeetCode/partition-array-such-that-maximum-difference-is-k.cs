using System;
using System.Linq;

namespace LeetCode
{
    public class partition_array_such_that_maximum_difference_is_k
    {
        public int PartitionArray(int[] nums, int k)
        {
            Array.Sort(nums);
            var min = nums.First();
            var res = 1;
            foreach (var item in nums)
            {
                if (item - min > k)
                {
                    res++;
                    min = item;
                }
            }

            return res;
        }
    }
}
