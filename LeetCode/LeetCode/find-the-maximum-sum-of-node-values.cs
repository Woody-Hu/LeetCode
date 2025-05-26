using System.Collections.Generic;
using System.Linq;

namespace LeetCode;

public class find_the_maximum_sum_of_node_values
{
    public long MaximumValueSum(int[] nums, int k, int[][] edges) {
        long res = nums.Sum(x => (long)x);
        List<int> diff = nums.Select(x => (x ^ k) - x).ToList();
        diff.Sort();
        for (int i = diff.Count - 1; i > 0 && diff[i] + diff[i - 1] >= 0; i -= 2) {
            res += diff[i] + diff[i - 1];
        }
        return res;
    }
}