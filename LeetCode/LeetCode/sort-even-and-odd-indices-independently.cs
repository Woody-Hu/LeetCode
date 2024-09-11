using System;

namespace LeetCode;

public class sort_even_and_odd_indices_independently
{
    public int[] SortEvenOdd(int[] nums) {
        var n = nums.Length;
        var evenCount = (n + 1) / 2;
        var oddCount = n - evenCount;
        var even = new int[evenCount];
        var odd = new int[oddCount];
        for (int i = 0, j = 0, k = 0; i < n; i++) {
            if (i % 2 == 0) {
                even[j] = nums[i];
                j++;
            } else {
                odd[k] = nums[i];
                k++;
            }
        }
        
        Array.Sort(even);
        Array.Sort(odd);
        
        for (int i = 0; i < evenCount; i++) {
            nums[i * 2] = even[i];
        }
        
        for (int i = 0; i < oddCount; i++) {
            nums[i * 2 + 1] = odd[oddCount - i - 1];
        }
        
        return nums;
    }
}