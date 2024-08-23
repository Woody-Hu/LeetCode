using System;

namespace LeetCode;

public class hqCnmP
{
    public int[] SupplyWagon(int[] supplies) {
        var m = supplies.Length/2;
        for (int n = supplies.Length; n > m; --n)
        {
            var j = 1;
            for (int i = 1;  i < n; ++i)
            {
                if (supplies[i] + supplies[i - 1] < supplies[j] + supplies[j - 1])
                {
                    j = i;
                }
                

            }
            
            supplies[j - 1] += supplies[j];
            for (int k = j + 1; k < n; ++k)
            {
                supplies[k - 1] = supplies[k];
            }
        }
        
        return new ArraySegment<int>(supplies).Slice(0, m).ToArray();

    }
}