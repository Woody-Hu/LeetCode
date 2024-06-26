using System;

namespace LeetCode;

public class TemperatureTrendSolution {
    public int TemperatureTrend(int[] temperatureA, int[] temperatureB) {
        var n = temperatureA.Length;
        var res = 0;
        var cur = 0;
        for (int i = 1; i < n; i++)
        {
            var ta = CalTrend(temperatureA[i - 1], temperatureA[i]);
            var tb = CalTrend(temperatureB[i - 1], temperatureB[i]);
            if (ta == tb)
            {
                cur++;
                res = Math.Max(res, cur);
            }
            else
            {
                cur = 0;
            }
        }
        
        return res;
    }

    private int CalTrend(int x, int y)
    {
        return x > y ? 1 : x < y ? -1 : 0;
    }
}