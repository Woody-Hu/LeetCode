using System;

namespace LeetCode;

public class maximum_median_sum_of_subsequences_of_size_3
{
    public long MaximumMedianSum(int[] nums) {
        Array.Sort(nums);
        int m = nums.Length / 3;
        long sum = 0;
        for (int j = 1; j <= m; j++) {
            sum += nums[3 * m - 2 * j];
        }
        return sum;
    }
}