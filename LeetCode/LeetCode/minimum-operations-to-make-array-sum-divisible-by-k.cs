using System.Linq;

namespace LeetCode;

public class minimum_operations_to_make_array_sum_divisible_by_k
{
    public int MinOperations(int[] nums, int k)
    {
        return nums.Sum() % k;
    }
}