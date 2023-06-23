using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class fHi6rV
	{
        static int[][] dirs = {
        new int[]{1, 0}, new int[]{-1, 0}, new int[]{0, 1}, new int[]{0, -1}, new int[]{1, 1}, new int[]{1, -1}, new int[]{-1, 1}, new int[]{-1, -1}
    };

        public int FlipChess(string[] chessboard)
        {
            int res = 0;
            for (int i = 0; i < chessboard.Length; ++i)
            {
                for (int j = 0; j < chessboard[0].Length; ++j)
                {
                    if (chessboard[i][j] == '.')
                    {
                        res = Math.Max(res, Bfs(chessboard, i, j));
                    }
                }
            }
            return res;
        }

        public int Bfs(string[] chessboard, int px, int py)
        {
            char[][] board = new char[chessboard.Length][];
            for (int i = 0; i < chessboard.Length; ++i)
            {
                board[i] = new char[chessboard[0].Length];
                for (int j = 0; j < chessboard[0].Length; ++j)
                {
                    board[i][j] = chessboard[i][j];
                }
            }
            int cnt = 0;
            Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
            queue.Enqueue(new Tuple<int, int>(px, py));
            board[px][py] = 'X';
            while (queue.Count > 0)
            {
                Tuple<int, int> t = queue.Dequeue();
                for (int i = 0; i < 8; ++i)
                {
                    if (Judge(board, t.Item1, t.Item2, dirs[i][0], dirs[i][1]))
                    {
                        int x = t.Item1 + dirs[i][0], y = t.Item2 + dirs[i][1];
                        while (board[x][y] != 'X')
                        {
                            queue.Enqueue(new Tuple<int, int>(x, y));
                            board[x][y] = 'X';
                            x += dirs[i][0];
                            y += dirs[i][1];
                            ++cnt;
                        }
                    }
                }
            }
            return cnt;
        }

        public bool Judge(char[][] board, int x, int y, int dx, int dy)
        {
            x += dx;
            y += dy;
            while (0 <= x && x < board.Length && 0 <= y && y < board[0].Length)
            {
                if (board[x][y] == 'X')
                {
                    return true;
                }
                else if (board[x][y] == '.')
                {
                    return false;
                }
                x += dx;
                y += dy;
            }
            return false;
        }
	}
}

