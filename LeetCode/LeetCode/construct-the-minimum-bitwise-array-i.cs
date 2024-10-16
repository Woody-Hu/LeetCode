using System.Collections.Generic;

namespace LeetCode;

public class construct_the_minimum_bitwise_array_i
{
    public int[] MinBitwiseArray(IList<int> nums) {
        int n = nums.Count;
        int[] ans = new int[n];
        for (int i = 0; i < n; i++) {
            ans[i] = Find(nums[i]);
        }
        
        return ans;
    }
    
    private int Find(int num) {
        if (num % 2 == 0) {
            return -1;
        } else {
            int lowbit = ((num + 1) & (-num - 1)) >> 1;
            return num - lowbit;
        }
    }
}