namespace LeetCode;

public class O4NDxx
{
    public class NumMatrix {
        
        private int[][] sums;

        public NumMatrix(int[][] matrix) {
            var m = matrix.Length;
            var n = matrix[0].Length;
            sums = new int[m + 1][];
            for (var i = 0; i < m + 1; i++) {
                sums[i] = new int[n + 1];
            }

            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    sums[i + 1][j + 1] = sums[i][j + 1] + sums[i + 1][j] - sums[i][j] + matrix[i][j];
                }
            }
        }
    
        public int SumRegion(int row1, int col1, int row2, int col2) {
            return sums[row2 + 1][col2 + 1] - sums[row1][col2 + 1] - sums[row2 + 1][col1] + sums[row1][col1];

        }
    }
}