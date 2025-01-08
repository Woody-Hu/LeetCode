using System;

namespace LeetCode;

public class minimum_cost_for_cutting_cake_i
{
    public int MinimumCost(int m, int n, int[] horizontalCut, int[] verticalCut) {
        Array.Sort(horizontalCut);
        Array.Sort(verticalCut);
        var res = 0;
        var i = m - 2;
        var j = n - 2;
        var h = 1;
        var v = 1;
        while (i >= 0 || j >= 0) {
            if (j < 0 || (i >= 0 && horizontalCut[i] > verticalCut[j])) {
                res += horizontalCut[i--] * v;
                ++h;
            } else {
                res += verticalCut[j--] * h;
                ++v;
            }
        }

        return res;

    }
}