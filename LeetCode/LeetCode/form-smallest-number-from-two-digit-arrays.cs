using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode;

public class form_smallest_number_from_two_digit_arrays
{
    public int MinNumber(int[] nums1, int[] nums2) {
        var s = Same(nums1, nums2);
        if (s != -1) {
            return s;
        }
        
        var x = nums1.Min();
        var y = nums2.Min();
        return Math.Min(x * 10 + y, y * 10 + x);
    }

    private int Same(int[] nums1, int[] nums2)
    {
        var set = new HashSet<int>();
        foreach (var num in nums1)
        {
            set.Add(num);
        }

        var x = 10;
        foreach (var num in nums2)
        {
            if (set.Contains(num))
            {
                x = Math.Min(x, num);
            }
        }
        
        return x == 10 ? -1 : x;
    }
}