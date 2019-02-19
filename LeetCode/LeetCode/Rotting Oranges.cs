using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Rotting_Oranges
    {
        public int OrangesRotting(int[][] grid)
        {
            var freshDic = new Dictionary<string,Point>();
            var rottenDic = new Dictionary<string, Point>();
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        var point = new Point(){X = i, Y = j};
                        freshDic.Add(point.ToString(),point);
                    }
                    else if (grid[i][j] == 2)
                    {
                        var point = new Point() { X = i, Y = j };
                        rottenDic.Add(point.ToString(), point);
                    }
                }
            }

            var count = 0;
            while (freshDic.Count != 0)
            {
                count++;
                var changeKeys = new List<string>();

                foreach (var oneKvp in freshDic)
                {
                    var point = oneKvp.Value;
                    foreach (var oneStr in point.GetNearStrArray())
                    {
                        if (rottenDic.ContainsKey(oneStr))
                        {
                            changeKeys.Add(point.ToString());
                            break;
                        }
                    }
                }

                if (0 == changeKeys.Count)
                {
                    return -1;
                }

                foreach (var oneKey in changeKeys)
                {
                    freshDic.Remove(oneKey, out var point);
                    rottenDic.Add(oneKey, point);
                }
            }

            return count;
        }

        private class Point
        {
            internal int X { set; get; }
            internal int Y { set; get; }
            private string _pointString { set; get; } = null;
            private string[] _nearStringArray { set; get; } = new string[4];

            public override string ToString()
            {
                if (null == _pointString)
                {
                    _pointString = $"{X}:{Y}";
                    _nearStringArray[0] = $"{X - 1}:{Y}";
                    _nearStringArray[1] = $"{X + 1}:{Y}";
                    _nearStringArray[2] = $"{X}:{Y - 1}";
                    _nearStringArray[3] = $"{X}:{Y + 1}";
                }
                return _pointString;
            }

            internal string[] GetNearStrArray()
            {
                return _nearStringArray;
            }
        }
    }
}
