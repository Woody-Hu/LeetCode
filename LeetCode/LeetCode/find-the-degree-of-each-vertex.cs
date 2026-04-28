namespace LeetCode;

public class find_the_degree_of_each_vertex
{
    public int[] FindDegrees(int[][] matrix) {
        int n = matrix.Length;
        int[] ans = new int[n];
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                ans[i] += matrix[i][j];
            }
        }
        return ans;
    }
}