using System;
namespace LeetCode
{
    public class minesweeper
    {
        private int[] _dirX = { 0, 1, 0, -1, 1, 1, -1, -1 };
        private int[] _dirY = { 1, 0, -1, 0, 1, -1, 1, -1 };

        public char[][] UpdateBoard(char[][] board, int[] click)
        {
            int x = click[0], y = click[1];
            if (board[x][y] == 'M')
            {
                // 规则 1
                board[x][y] = 'X';
            }
            else
            {
                DFS(board, x, y);
            }

            return board;
        }

        public void DFS(char[][] board, int x, int y)
        {
            int cnt = 0;
            for (int i = 0; i < 8; ++i)
            {
                int tx = x + _dirX[i];
                int ty = y + _dirY[i];
                if (tx < 0 || tx >= board.Length || ty < 0 || ty >= board[0].Length)
                {
                    continue;
                }
                if (board[tx][ty] == 'M')
                {
                    ++cnt;
                }
            }
            if (cnt > 0)
            {
                board[x][y] = (char)(cnt + '0');
            }
            else
            {
                board[x][y] = 'B';
                for (int i = 0; i < 8; ++i)
                {
                    int tx = x + _dirX[i];
                    int ty = y + _dirY[i];
                    if (tx < 0 || tx >= board.Length || ty < 0 || ty >= board[0].Length || board[tx][ty] != 'E')
                    {
                        continue;
                    }
                    DFS(board, tx, ty);
                }
            }
        }
    }
}
