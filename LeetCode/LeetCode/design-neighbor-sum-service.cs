using System.Collections.Generic;

namespace LeetCode;

public class design_neighbor_sum_service
{
    public class neighborSum
    {
        private List<List<int>> directions = new()
        {
            new List<int> { -1, 0 },
            new List<int> { 1, 0 },
            new List<int> { 0, -1 },
            new List<int> { 0, 1 },
            new List<int> { 1, 1 },
            new List<int> { -1, 1 },
            new List<int> { -1, -1 },
            new List<int> { 1, -1 },
        };

        private int[][] sum;

        public neighborSum(int[][] grid) {
            var n = grid.Length;
            sum = new int[n * n][];
            for (var i = 0; i < n * n; i++) {
                sum[i] = new int[2];
            }
            
            for (var i = 0; i < n; i++) {
                for (var j = 0; j < n; j++) {
                    for (var k = 0; k < 8; k++)
                    {
                        var x = i + directions[k][0];
                        var y = j + directions[k][1];
                        if (x >= 0 && x < n && y >= 0 && y < n) {
                            sum[grid[i][j]][k/4] += grid[x][y];
                        }
                    }
                }
            }
        }
    
        public int AdjacentSum(int value)
        {
            return sum[value][0];

        }
    
        public int DiagonalSum(int value) {
            return sum[value][1];
        }
    }
}