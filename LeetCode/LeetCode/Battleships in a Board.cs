using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace LeetCode
{
    class Battleships_in_a_Board
    {
        public int CountBattleships(char[][] board)
        {
            var count = 0;

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == '.')
                    {
                        continue;
                    }
                    else if (i >0 && board[i-1][j] == 'X')
                    {
                        continue;
                    }
                    else if (j > 0 && board[i][j - 1] == 'X')
                    {
                        continue;
                    }

                    count++;
                }
            }

            return count;
        }
    }
}
