using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class WalkingRobotSimulation
    {
        public int RobotSim(int[] commands, int[][] obstacles)
        {
            int returnValue = 0;

            HashSet<string> usedSet = new HashSet<string>();

            foreach (var oneValue in obstacles)
            {
                usedSet.Add(oneValue[0] + "," + oneValue[1]);
            }

            int direction = 0, x = 0, y = 0;
            int[][] directions = {new int[]{ 0, 1 }, new int[] { 1, 0 }, new int[] { 0, -1 }, new int[] { -1, 0 } };

            foreach (var oneCommand in commands)
            {
                if (oneCommand == -1)
                {
                    direction = (direction + 1) % 4;
                }
                else if (oneCommand == -2)
                {
                    direction = (direction - 1) % 4;
                    if (direction < 0)
                    {
                        direction += 4;
                    }
                }
                else if (oneCommand >= 1 && oneCommand <=9)
                {
                    for (int i = 1; i <= oneCommand; i++)
                    {
                        var nextX = x + directions[direction][0];
                        var nextY = y + directions[direction][1];

                        if (usedSet.Contains(nextX+","+nextY))
                        {
                            break;
                        }

                        x = nextX;
                        y = nextY;
                        returnValue = Math.Max(returnValue, x * x + y * y);
                    }
                }
            }

            return returnValue;

        }
    }
}
