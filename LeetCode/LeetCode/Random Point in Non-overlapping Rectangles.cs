using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Random_Point_in_Non_overlapping_Rectangles
    {
        private int[] _areas;

        private int[][] _rects;

        private Random _random = new Random();

        public Random_Point_in_Non_overlapping_Rectangles(int[][] rects)
        {
            _rects = rects;
            _areas = new int[rects.Length];
            for (int i = 0; i < rects.Length; i++)
            {
                int area = (rects[i][2] - rects[i][0] + 1) * (rects[i][3] - rects[i][1] + 1);
                _areas[i] = (i == 0) ? area : area + _areas[i - 1];
            }
        }

        public int[] Pick()
        {
            var randomArea = 1 + _random.Next(_areas[_areas.Length-1]);
            var index = Array.BinarySearch(_areas, randomArea);
            if (index < 0)
            {
                index = ~index;
            }
            int[] rect = _rects[index];
            int x = rect[0] + _random.Next(rect[2] - rect[0] + 1);
            int y = rect[1] + _random.Next(rect[3] - rect[1] + 1);
            return new int[] { x, y };
        }
    }
}
