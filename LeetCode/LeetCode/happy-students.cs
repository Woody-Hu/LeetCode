using System.Collections.Generic;

namespace LeetCode;

public class happy_students
{
    public int CountWays(IList<int> nums) {
        int n = nums.Count;
        int res = 0;
        ((List<int>) nums).Sort();
        for (int k = 0; k <= n; k++) {
            if (k > 0 && nums[k - 1] >= k) {
                continue;
            }
            
            if (k < n && nums[k] <= k) {
                continue;
            }
            res++;
        }
        
        return res;
    }
}