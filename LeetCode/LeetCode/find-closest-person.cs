using System;

namespace LeetCode;

public class find_closest_person
{
    public int FindClosest(int x, int y, int z)
    {
        var d1 = Math.Abs(x - z);
        var d2 = Math.Abs(y - z);
        return d1 == d2?0:d1 < d2?1:2;

    }
}