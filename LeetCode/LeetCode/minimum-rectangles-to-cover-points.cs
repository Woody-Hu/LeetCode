using System;

namespace LeetCode;

public class minimum_rectangles_to_cover_points
{
    public int MinRectanglesToCoverPoints(int[][] points, int w) {
        Array.Sort(points, (a, b) => a[0] - b[0]);
        var res = 0;
        var bound = -1;
        foreach (var p in points) {
            if (p[0] > bound) {
                bound = p[0] + w;
                res++;
            }
        }
        
        return res;
    }
}