using System.Collections.Generic;

namespace LeetCode;

public class final_array_state_after_k_multiplication_operations_i
{
    public int[] GetFinalState(int[] nums, int k, int multiplier) {
        if (multiplier == 1) {
            return nums;
        }
        
        var pq = new PriorityQueue<int, long>();
        var n = nums.Length;
        for (var i = 0; i < n; i++) {
            pq.Enqueue(i, (long) nums[i] * n + i);
        }
        while (k > 0) {
            var index = pq.Dequeue();;
            nums[index] *= multiplier;
            pq.Enqueue(index, (long) nums[index] * n + index);
            k--;
        }
        return nums;
    }
}