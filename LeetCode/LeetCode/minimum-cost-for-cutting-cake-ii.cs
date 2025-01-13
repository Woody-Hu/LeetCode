using System;

namespace LeetCode;

public class minimum_cost_for_cutting_cake_ii
{
    public long MinimumCost(int m, int n, int[] horizontalCut, int[] verticalCut) {
        Array.Sort(horizontalCut);
        Array.Sort(verticalCut);
        int h = 1, v = 1;
        long res = 0;
        int horizontalIndex = horizontalCut.Length - 1, verticalIndex = verticalCut.Length - 1;
        while (horizontalIndex >= 0 || verticalIndex >= 0) {
            if (verticalIndex < 0 || (horizontalIndex >= 0 && horizontalCut[horizontalIndex] > verticalCut[verticalIndex])) {
                res += horizontalCut[horizontalIndex--] * h;
                v++;
            } else {
                res += verticalCut[verticalIndex--] * v;
                h++;
            }
        }
        
        return res;
    }
}