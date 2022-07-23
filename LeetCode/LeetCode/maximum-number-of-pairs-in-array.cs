using System;
namespace LeetCode
{
    public class maximum_number_of_pairs_in_array
    {
        public int[] NumberOfPairs(int[] nums)
        {
            var temp = new int[101];
            foreach (var item in nums)
            {
                temp[item]++;
            }

            var count = 0;
            foreach (var item in temp)
            {
                count += item / 2;
            }

            return new int[] { count, nums.Length - 2 * count };
        }
    }
}

