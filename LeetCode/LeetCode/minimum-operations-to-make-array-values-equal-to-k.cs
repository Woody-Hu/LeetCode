using System.Collections.Generic;
using System.Linq;

namespace LeetCode;

public class minimum_operations_to_make_array_values_equal_to_k
{
    public int MinOperations(int[] nums, int k) {
        var min = nums.Min();
        if (k > min)
        {
            return -1;
        }
        
        var set = new HashSet<int>();
        foreach (var item in nums)
        {
            set.Add(item);
        }

        return set.Count - (k == min ? 1 : 0);

    }
}