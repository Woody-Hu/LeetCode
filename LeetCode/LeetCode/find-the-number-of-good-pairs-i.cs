using System.Collections.Generic;

namespace LeetCode;

public class find_the_number_of_good_pairs_i
{
    public int NumberOfPairs(int[] nums1, int[] nums2, int k)
    {
        var cnt = new Dictionary<int, int>();
        foreach (var x in nums1)
        {
            var xt = x;
            if (xt % k != 0)
            {
                continue;
            }

            xt /= k;
            for (int i = 1; i * i <= xt; i++)
            {
                if (xt % i >0)
                {
                    continue;
                }
                
                if (cnt.ContainsKey(i))
                {
                    cnt[i]++;
                }
                else
                {
                    cnt[i] = 1;
                }
                
                if (i * i < xt)
                {
                    if (cnt.ContainsKey(xt / i))
                    {
                        cnt[xt / i]++;
                    }
                    else
                    {
                        cnt[xt / i] = 1;
                    }
                }
            }
        }

        var ans = 0l;
        foreach (var y in nums2)
        {
            if (cnt.ContainsKey(y))
            {
                ans += cnt[y];
            }
        }
        
        return (int)ans;
    }
}