using System;

namespace LeetCode;

public class cyJERH
{
    public int MinFlipsMonoIncr(string s) {
        var n = s.Length;
        var dp0 = 0;
        var dp1 = 0;
        for (var i = 0; i < n; i++)
        {
            var c = s[i];
            var dp0new = dp0;
            var dp1new = Math.Min(dp0, dp1);
            if (c == '1')
            {
                dp0new++;
            }
            else
            {
                dp1new++;
            }
            
            dp0 = dp0new;
            dp1 = dp1new;
        }
        
        return Math.Min(dp0, dp1);
    }
}