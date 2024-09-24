namespace LeetCode;

public class make_a_square_with_the_same_color
{
    public bool CanMakeSquare(char[][] grid) {
             for (int i = 0; i <= 1; i++) {
                 for (int j = 0; j <= 1; j++) {
                     if (Check(grid, i, j)) {
                         return true;
                     }
                 }
             }
             return false;
         }
     
         public bool Check(char[][] grid, int x, int y) {
             int count = 0;
             for (int i = 0; i <= 1; i++) {
                 for (int j = 0; j <= 1; j++) {
                     if (grid[x + i][y + j] == 'B') {
                         count++;
                     }
                 }
             }
             return count != 2;
         }
}