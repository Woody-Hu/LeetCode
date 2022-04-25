using System;
namespace LeetCode
{
    public class TicTacToe
    {
        private int[,] _values;
        private int _n;

        public TicTacToe(int n)
        {
            _n = n;
            _values = new int[n, n];
        }

        public int Move(int row, int col, int player)
        {
            _values[row, col] = player;
            var win = true;
            for (int i = 0; i < _n; i++)
            {
                if (_values[row, i] != player)
                {
                    win = false;
                    break;
                }
            }

            if (win)
            {
                return player;
            }

            win = true;
            for (int i = 0; i < _n; i++)
            {
                if (_values[i, col] != player)
                {
                    win = false;
                    break;
                }
            }

            if (win)
            {
                return player;
            }

            win = true;
            for (int i = 0; i < _n; i++)
            {
                if (_values[i, i] != player)
                {
                    win = false;
                    break;
                }
            }

            if (win)
            {
                return player;
            }

            win = true;
            for (int i = 0; i < _n; i++)
            {
                if (_values[i, _n -1 - i] != player)
                {
                    win = false;
                    break;
                }
            }

            if (win)
            {
                return player;
            }

            return 0;
        }
    }
}
