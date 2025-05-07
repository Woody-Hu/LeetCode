namespace LeetCode;

public class fill_a_special_grid
{
    public int[][] SpecialGrid(int n) {
        int side = 1 << n;
        int[][] grid = new int[side][];
        for (int i = 0; i < side; i++) {
            grid[i] = new int[side];
        }
        grid[0][side - 1] = 0;
        for (int i = 1, prevSide = 1, diff = 1; i <= n; i++, prevSide <<= 1, diff <<= 2) {
            for (int j = 0; j < prevSide; j++) {
                for (int k = side - prevSide; k < side; k++) {
                    grid[j + prevSide][k] = grid[j][k] + diff;
                    grid[j + prevSide][k - prevSide] = grid[j][k] + 2 * diff;
                    grid[j][k - prevSide] = grid[j][k] + 3 * diff;
                }
            }
        }
        return grid;
    }
}