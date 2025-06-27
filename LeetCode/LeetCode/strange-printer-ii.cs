using System;
using System.Collections.Generic;

namespace LeetCode;

public class strange_printer_ii
{
    private const int COLOR = 61;

    public bool IsPrintable(int[][] targetGrid) {
        int m = targetGrid.Length;
        int n = targetGrid[0].Length;
        
        int[] up = new int[COLOR];
        Array.Fill(up, int.MaxValue);
        int[] down = new int[COLOR];
        int[] left = new int[COLOR];
        Array.Fill(left, int.MaxValue);
        int[] right = new int[COLOR];
        HashSet<int> occur = new HashSet<int>();
        
        for (int i = 0; i < m; ++i) {
            for (int j = 0; j < n; ++j) {
                int color = targetGrid[i][j];
                occur.Add(color);
                up[color] = Math.Min(up[color], i);
                down[color] = Math.Max(down[color], i);
                left[color] = Math.Min(left[color], j);
                right[color] = Math.Max(right[color], j);
            }
        }

        bool[][] g = new bool[COLOR][];
        for (int i = 0; i < COLOR; i++) {
            g[i] = new bool[COLOR];
        }
        
        int[] indeg = new int[COLOR];
        int nodes = occur.Count;
        
        foreach (int outside in occur) {
            for (int i = up[outside]; i <= down[outside]; ++i) {
                for (int j = left[outside]; j <= right[outside]; ++j) {
                    int color = targetGrid[i][j];
                    if (outside != color && !g[outside][color]) {
                        g[outside][color] = true;
                        ++indeg[color];
                    }
                }
            }
        }
        
        Queue<int> queue = new Queue<int>();
        foreach (int color in occur) {
            if (indeg[color] == 0) {
                queue.Enqueue(color);
            }
        }
        
        while (queue.Count > 0) {
            int u = queue.Dequeue();
            --nodes;
            for (int v = 1; v < COLOR; ++v) {
                if (g[u][v]) {
                    --indeg[v];
                    if (indeg[v] == 0) {
                        queue.Enqueue(v);
                    }
                }
            }
        }

        return nodes == 0;
    }
}