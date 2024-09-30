using System;

namespace LeetCode;

public class minimum_element_after_replacement_with_digit_sum
{
    public int MinElement(int[] nums)
    {
        var res = int.MaxValue;
        foreach (var item in nums)
        {
            var temp = item;
            var s = 0;
            while (temp > 0)
            {
                s += temp % 10;
                temp /= 10;
            }
            
            res = Math.Min(res, s);
        }
        
        return res;
    }
}