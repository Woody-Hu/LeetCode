using System;

namespace LeetCode;

public class minimum_number_of_operations_to_make_arrays_similar
{
    public long MakeSimilar(int[] nums, int[] target)
    {
        InternalSort(ref nums);
        InternalSort(ref target);
        var res = 0L;
        for (var i = 0; i < nums.Length; ++i)
        {
            res += Math.Abs(nums[i] - target[i]);
        }
        
        return res / 4;
    }

    private void InternalSort(ref int[] a)
    {
        for (var i = 0; i < a.Length; ++i)
            if (a[i] % 2 != 0) a[i] = -a[i];
        
        Array.Sort(a);
    }
}