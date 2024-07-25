using System;

namespace LeetCode;

public class W2ZX4X
{
    public int RuneReserve(int[] runes) {
        Array.Sort(runes);
        var res = 0;
        var count = 1;
        for (int i = 1; i < runes.Length; i++)
        {
            if (runes[i] - runes[i - 1] > 1)
            {
                count = 1;
            }
            else
            {
                res = Math.Max(res, ++count);
            }
        }
        
        return res;
    }
}