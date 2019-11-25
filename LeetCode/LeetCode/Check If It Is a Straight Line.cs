using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Check_If_It_Is_a_Straight_Line
    {
        public bool CheckStraightLine(int[][] coordinates)
        {
            float x1 = coordinates[0][0], y1 = coordinates[0][1], x2 = coordinates[1][0], y2 = coordinates[1][1];
            float k = (y2 - y1) / (x2 - x1);
            float b = -1 * k * x1 + y1;
            for (int i = 2; i < coordinates.Length; i++)
            {
                if (coordinates[i][1] != k * coordinates[i][0] + b) 
                    return false;
            }

            return true;
        }
    }
}
