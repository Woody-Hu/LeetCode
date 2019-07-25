using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Random_Pick_with_Weight
    {
        private int[] _w;
        private int _sum;
        private Random _random = new Random();


        public Random_Pick_with_Weight(int[] w)
        {
            _w = new int[w.Length];
            var sum = 0;
            for (int i = 0; i < w.Length; i++)
            {
                _w[i] = sum;
                sum += w[i];
            }

            _sum = sum;
        }

        public int PickIndex()
        {
            var index = _random.Next(_sum);
            int lo = 0, hi = _w.Length - 1;
            while (lo < hi)
            {
                int mid = lo + (hi - lo) / 2 + 1;
                if (_w[mid] == index)
                    return mid;

                if (_w[mid] > index)
                {
                    hi = mid - 1;
                }
                else
                {
                    lo = mid;
                }
            }
            return lo;
        }
    }
}
