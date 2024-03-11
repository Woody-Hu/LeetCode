using System;
using System.Linq;

namespace LeetCode;

public class apple_redistribution_into_boxes
{
    public int MinimumBoxes(int[] apple, int[] capacity)
    {
        var res = 0;
        res = apple.Sum();
        Array.Sort(capacity);
        var n = capacity.Length;
        var i = n - 1;
        while (res > 0)
        {
            res -= capacity[i];
            i--;
        }
        
        return n - i - 1;
    }
}