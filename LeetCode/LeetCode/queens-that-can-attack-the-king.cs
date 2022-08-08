using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class queens_that_can_attack_the_king
    {
        public IList<IList<int>> QueensAttacktheKing(int[][] queens, int[] king)
        {
            var board = new char[8, 8];
            foreach (var item in queens)
            {
                board[item[0], item[1]] = 'Q';
            }

            var directions = new List<List<int>> { new List<int>{ -1, 0 }, new List<int> { -1, 1 }, new List<int> { 0, 1 }, new List<int> { 1, 1 }, new List<int> { 1, 0 }, new List<int> { 1, -1 }, new List<int> { 0, -1 }, new List<int> { -1, -1 } };
            var res = new List<IList<int>>();
            foreach (var item in directions)
            {
                Visit(res, king[0], king[1], board, item[0], item[1]);
            }

            return res;
        }

        private bool Visit(IList<IList<int>> res, int x, int y, char[,] data, int xIncrease, int yIncrease)
        {
            if (x < 0 || y < 0 || x >= 8 || y >= 8)
            {
                return false;
            }

            if (data[x, y] == 'Q')
            {
                res.Add(new List<int>() { x, y });
                return true;
            }

            return Visit(res, x + xIncrease, y + yIncrease, data, xIncrease, yIncrease);
        }
    }
}
