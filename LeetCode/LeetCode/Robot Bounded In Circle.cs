using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace LeetCode
{
    class Robot_Bounded_In_Circle
    {
        public bool IsRobotBounded(string instructions)
        {
            var x = 0;
            var y = 0;
            var moves = new int[][] {new[] {0, 1}, new[] {1, 0}, new[] {0, -1}, new[] {-1, 0}};
            var moveIndex = 0;
            foreach (var oneMove in instructions)
            {
                if (oneMove == 'R')
                {
                    moveIndex = (moveIndex + 1) % 4;
                }
                else if (oneMove == 'L')
                {
                    moveIndex = (moveIndex + 3) % 4;
                }
                else
                {
                    x += moves[moveIndex][0];
                    y += moves[moveIndex][1];
                }
            }


            return (x == 0 && y == 0) || moveIndex != 0;
        }
    }
}
