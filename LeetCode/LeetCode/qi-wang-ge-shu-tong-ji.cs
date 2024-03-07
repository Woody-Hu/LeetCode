using System.Collections.Generic;

namespace LeetCode;

public class qi_wang_ge_shu_tong_ji
{
    public int ExpectNumber(int[] scores)
    {
        var set = new HashSet<int>();
        foreach (var score in scores)
        {
            set.Add(score);
        }

        return set.Count;
    }
}