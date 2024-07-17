namespace LeetCode;

public class special_positions_in_a_binary_matrix
{
    public int NumSpecial(int[][] mat) {
        var m = mat.Length;
        var n = mat[0].Length;
        var rowSum = new int[m];
        var colSum = new int[n];
        var res = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                rowSum[i] += mat[i][j];
                colSum[j] += mat[i][j];
            }
        }
        
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (mat[i][j] == 1 && rowSum[i] == 1 && colSum[j] == 1) {
                    res++;
                }
            }
        }
        return res;
    }
}