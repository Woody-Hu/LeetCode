using System;

namespace LeetCode;

public class maximum_height_of_a_triangle
{
    public int MaxHeightOfTriangle(int red, int blue)
    {
        return Math.Max(CalMaxHeight(red, blue), CalMaxHeight(blue, red));
    }

    private int CalMaxHeight(int x, int y)
    {
        int odd = 2 * (int)(Math.Sqrt(x)) - 1;
        int even = 2 * (int)((-1 + Math.Sqrt(1 + 4 * y)) / 2);
        return Math.Min(odd, even) + 1;
    }
}