using System.Collections.Generic;

namespace LeetCode;

public class he_wei_sde_lian_xu_zheng_shu_xu_lie_lcof
{
    public int[][] FileCombination(int target) {
        var res = new List<int[]>();
        for (int l = 1, r = 2; l < r; )
        {
            var sum = (l + r) * (r - l + 1) / 2;
            if (sum == target)
            {
                var arr = new int[r - l + 1];
                for (int i = l; i <= r; i++)
                {
                    arr[i - l] = i;
                }
                res.Add(arr);
                l++;
            }
            else if (sum < target)
            {
                r++;
            }
            else
            {
                l++;
            }
        }
        
        return res.ToArray();

    }
}