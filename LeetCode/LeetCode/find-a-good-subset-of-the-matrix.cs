using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LeetCode;

public class find_a_good_subset_of_the_matrix
{
    public IList<int> GoodSubsetofBinaryMatrix(int[][] grid) {
        var res = new List<int>();
        var dic = new Dictionary<int, int>();
        var m = grid.Length;
        var n = grid[0].Length;
        for (int i = 0; i < m; i++)
        {
            var mask = 0;
            for (int j = 0; j < n; j++)
            {
                mask |= (grid[i][j] << j);
            }

            dic[mask] = i;
        }

        if (dic.ContainsKey(0))
        {
            res.Add(dic[0]);
            return res;
        }

        foreach (var pair in dic)
        {
            var x = pair.Key;
            var i = pair.Value;
            foreach (var pair2 in dic)
            {
                var y = pair2.Key;
                var j = pair2.Value;
                if ((x & y) == 0)
                {
                    var newRes = new List<int>();
                    newRes.Add(Math.Min(i, j));
                    newRes.Add(Math.Max(i, j));
                    return newRes;
                }
            }
        }

        return res;
    }
}