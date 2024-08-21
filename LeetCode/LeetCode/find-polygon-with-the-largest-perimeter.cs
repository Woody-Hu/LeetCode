using System;

namespace LeetCode;

public class find_polygon_with_the_largest_perimeter
{
    public long LargestPerimeter(int[] nums) {
        Array.Sort(nums);
        var sum = 0l;
        foreach (var num in nums)
        {
            sum += num;
        }

        for (int i = nums.Length - 1; i > 1; i--)
        {
            var temp = nums[i];
            if (sum > temp*2)
            {
                return sum;
            }
            
            sum -= temp;
        }

        return -1;
    }
}