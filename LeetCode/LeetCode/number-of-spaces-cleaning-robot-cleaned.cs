using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class number_of_spaces_cleaning_robot_cleaned
    {
        public int NumberOfCleanRooms(int[][] room)
        {
            var res = 0;
            var directions = new List<int[]>() { new int[] { 0, 1 }, new int[] { 1, 0 }, new int[] { 0, -1 }, new int[] { -1, 0 } };
            var visited = new Dictionary<string, int>();
            Visist(0, 0, room.Length, room[0].Length, room, visited, directions, 0, ref res);
            return res;
        }

        private int Visist(int x, int y, int xLimit, int yLimit, int[][] room, Dictionary<string, int> visit, List<int[]> directions, int currentDirection, ref int res)
        {
            if (x < 0 || x >= xLimit)
            {
                return -1;
            }

            if (y < 0 || y >= yLimit)
            {
                return -1;
            }

            var location = $"{x},{y}";
            if (visit.TryGetValue(location, out var locationCount) && locationCount >= 3)
            {
                return 1;
            }

            if (room[x][y] == 1)
            {
                return -1;
            }

            if (!visit.ContainsKey(location))
            {
                visit.Add(location, 0);
                res++;
            }

            visit[location]++;
            for (int i = 0; i < 4; i++)
            {
                var nextX = x + directions[currentDirection][0];
                var nextY = y + directions[currentDirection][1];
                var next = Visist(nextX, nextY, xLimit, yLimit, room, visit, directions, currentDirection, ref res);
                if (next == 0)
                {
                    break;
                }
                else if (next == 1)
                {
                    return 1;
                }

                currentDirection = (currentDirection + 1) % 4;
            }

            return 0;
        }
    }
}
