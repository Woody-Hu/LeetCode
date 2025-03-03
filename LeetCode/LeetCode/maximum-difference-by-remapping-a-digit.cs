using System;

namespace LeetCode;

public class maximum_difference_by_remapping_a_digit
{
    public int MinMaxDifference(int num)
    {
        var max = num;
        var s = num.ToString();
        var n = s.Length;
        for (int i = 0; i < s.Length; i++)
        {
            var c = s[i];
            if (c != '9')
            {
                max = Math.Max(max, int.Parse(s.Replace(c, '9')));
                break;
            }

        }
        
        return max - int.Parse(s.Replace(s[0], '0'));
    }
}