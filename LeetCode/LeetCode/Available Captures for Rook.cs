using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Available_Captures_for_Rook
    {
        public int NumRookCaptures(char[][] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == 'R')
                    {
                        return NumRookCaptures(board, i, j, 1, 0) + NumRookCaptures(board, i, j, -1, 0) +
                               NumRookCaptures(board, i, j, 0, 1) + NumRookCaptures(board, i, j, 0, -1);
                    }
                }
            }

            return 0;
        }

        private int NumRookCaptures(char[][] board, int x, int y, int moveX, int moveY)
        {
            while (x >=0 && x < board.GetLength(0) && y >= 0 && y < board[x].Length && board[x][y] != 'B')
            {
                if (board[x][y] == 'p')
                {
                    return 1;
                }

                x += moveX;
                y += moveY;
            }

            return 0;
        }
    }
}
