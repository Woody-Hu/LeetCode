using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode;

public class toggle_light_bulbs
{
    public IList<int> ToggleLightBulbs(IList<int> bulbs) {
        
        int[] memo = new int[101];
        foreach (int bulb in bulbs)
        {
            memo[bulb] ^= 1;
        }
        List<int> ans = new List<int>();
        for (int i = 1; i < 101; i++)
        {
            if (memo[i] == 1)
            {
                ans.Add(i);
            }
        }
        return ans;
    }
}