namespace LeetCode;

public class flip_square_submatrix_vertically
{
    public int[][] ReverseSubmatrix(int[][] grid, int x, int y, int k) {
        for (int top = x, bottom = x + k - 1; top < bottom; top++, bottom--) {
            for (int j = 0; j < k; j++) {
                int temp = grid[top][y + j];
                grid[top][y + j] = grid[bottom][y + j];
                grid[bottom][y + j] = temp;
            }
        }
        
        return grid;
    }
}