using System;
using System.Collections.Generic;

namespace LeetCode;

public class generate_binary_strings_without_adjacent_zeros
{
    public IList<string> ValidStrings(int n)
    {
        var res = new List<string>();
        var mask = (1 << n) - 1;
        for (int i = 0; i <= mask; i++)
        {
            var x = mask ^ i;
            if (((x >> 1) & x) == 0)
            {
                res.Add(Convert.ToString(i, 2).PadLeft(n, '0'));
            }
        }

        return res;

    }
}