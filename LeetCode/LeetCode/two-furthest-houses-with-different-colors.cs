using System;

namespace LeetCode;

public class two_furthest_houses_with_different_colors
{
    public int MaxDistance(int[] colors)
    {
        var res = 0;
        var n = colors.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (colors[i] != colors[j])
                {
                    res = Math.Max(res, j - i);
                }
            }
        }

        return res;
    }
}