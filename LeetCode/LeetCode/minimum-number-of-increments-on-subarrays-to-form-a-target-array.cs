using System;

namespace LeetCode;

public class minimum_number_of_increments_on_subarrays_to_form_a_target_array
{
    public int MinNumberOperations(int[] target) {
        var n = target.Length;
        var res = target[0];    
        for (var i = 1; i < n; i++)
        {
            res += Math.Max(0, target[i] - target[i - 1]);
        }
        
        return res;
        
    }
}