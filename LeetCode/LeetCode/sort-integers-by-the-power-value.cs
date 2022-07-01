using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class sort_integers_by_the_power_value
    {
        public int GetKth(int lo, int hi, int k)
        {
            var list = new List<int>();
            for (int i = lo; i <= hi; i++)
            {
                list.Add(i);
            }

            var array = list.ToArray();
            Array.Sort(array, new InternaComparer());
            return array[k - 1];
        }

        private class InternaComparer : IComparer<int>
        {
            private Dictionary<int, int> _map = new Dictionary<int, int>();

            public int Compare(int x, int y)
            {
                var powerX = GetPower(x);
                var powerY = GetPower(y);
                if (powerX != powerY)
                {
                    return powerX - powerY;
                }
                else
                {
                    return x - y;
                }
            }

            private int GetPower(int x)
            {
                if (_map.TryGetValue(x, out var exist))
                {
                    return exist;
                }

                if (x == 1)
                {
                    _map[x] = 0;
                }
                else if ((x & 1) != 0)
                {
                    _map[x] = GetPower(x * 3 + 1) + 1;
                }
                else
                {
                    _map[x] = GetPower(x/2) + 1;
                }

                return _map[x];
            }
        }
    }
}
