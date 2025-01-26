using System.Linq;

namespace LeetCode;

public class count_partitions_with_even_sum_difference
{
    public int CountPartitions(int[] nums) {
        var sum = nums.Sum();
        return sum % 2 > 0? 0: nums.Length - 1;
        
    }
}