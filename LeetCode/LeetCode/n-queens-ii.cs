using System;
namespace LeetCode
{
	public class n_queens_ii
	{
        public int TotalNQueens(int n)
        {
            return Solve(n, 0, 0, 0, 0);
        }

        private int Solve(int n, int row, int column, int diagonals1, int diagonals2)
        {
            if (row == n)
            {
                return 1;
            }

            int count = 0;
            int available = ((1 << n) - 1) & (~(column | diagonals1 | diagonals2));
            while (available != 0)
            {
                var p = available & (-available);
                available = available & (available - 1);
                count += Solve(n, row + 1, column | p, (diagonals1 | p) << 1, (diagonals2 | p) >> 1);
            }

            return count;
        }
    }
}

