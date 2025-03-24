using System;

namespace LeetCode;

public class maximum_containers_on_a_ship
{
    public int MaxContainers(int n, int w, int maxWeight)
    {
        return Math.Min(maxWeight / w, n * n);

    }
}