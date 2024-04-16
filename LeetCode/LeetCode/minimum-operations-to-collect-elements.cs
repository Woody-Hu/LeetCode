using System.Collections.Generic;

namespace LeetCode;

public class minimum_operations_to_collect_elements
{
    public int MinOperations(IList<int> nums, int k) {
        var n = nums.Count;
        var u = (2l << k) - 2;
        var s = 0l;
        for (int i = n - 1; ; i--)
        {
            s |= 1L << nums[i];
            if ((s & u) == u)
                return n - i;
        }

    }
}