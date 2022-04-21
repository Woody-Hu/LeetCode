using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class maximum_number_of_events_that_can_be_attended
    {
        private int[] _parents;

        public int MaxEvents(int[][] events)
        {
            var ordered = events.OrderBy(k => k[1]).ThenBy(k => k[0]);
            var n = ordered.Count();
            _parents = new int[ordered.Last()[1] + 2];
            for (int i = 0; i < _parents.Length; i++)
            {
                _parents[i] = i;
            }

            var res = 0;
            foreach (var item in ordered)
            {
                var day = Find(item[0]);
                if (day <= item[1])
                {
                    res++;
                    _parents[Find(day)] = Find(day + 1);
                }
            }

            return res;
        }

        private int Find(int i)
        {
            if (_parents[i] == i)
            {
                return i;
            }
            else
            {
                _parents[i] = Find(_parents[i]);
                return _parents[i];
            }
        }
    }
}
