using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode;

public class a569nqc {
    public int FindMinDifference(IList<string> timePoints) {
        timePoints = timePoints.OrderBy(x => x).ToList();
        int ans = int.MaxValue;
        int t0Minutes = getMinutes(timePoints[0]);
        int preMinutes = t0Minutes;
        for (int i = 1; i < timePoints.Count; ++i) {
            int minutes = getMinutes(timePoints[i]);
            ans = Math.Min(ans, minutes - preMinutes); // 相邻时间的时间差
            preMinutes = minutes;
        }
        ans = Math.Min(ans, t0Minutes + 1440 - preMinutes); // 首尾时间的时间差
        return ans;
    }

    public int getMinutes(string t) {
        return ((t[0] - '0') * 10 + (t[1] - '0')) * 60 + (t[3] - '0') * 10 + (t[4] - '0');
    }
}