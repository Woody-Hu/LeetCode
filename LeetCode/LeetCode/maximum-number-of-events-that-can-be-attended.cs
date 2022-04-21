using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class maximum_number_of_events_that_can_be_attended
    {

        public int MaxEvents(int[][] events)
        {
            var n = events.Count();
            var union = new Union(events);
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (union.CanMerge(j, i))
                    {
                        union.Merge(i, j);
                    }
                }
            }

            return union.GetResult();
        }

        private class Union
        {
            private int[] _parents;
            private Dictionary<int, int[]> _values = new Dictionary<int, int[]>(); 

            public Union(int[][] events)
            {
                var n = events.Count();
                _parents = new int[n];
                for (int i = 0; i < n; i++)
                {
                    _parents[i] = i;
                    _values[i] = events[i];
                }
            }

            public int Find(int i)
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

            public void Merge(int first, int second)
            {
                var secondParentIndex = Find(second);
                var firstParentIndex = Find(first);
                var secondValue = _values[secondParentIndex];
                var firstValue = _values[firstParentIndex];
                _parents[Find(secondParentIndex)] = Find(firstParentIndex);
                var newValue = new int[] { Math.Min(firstValue[0], secondValue[0]), Math.Max(firstValue[1], secondValue[1]) };
                _values[firstParentIndex] = newValue;
            }

            public bool CanMerge(int first, int second)
            {
                var secondParentIndex = Find(second);
                var firstParentIndex = Find(first);
                if (_values[firstParentIndex][1] >= _values[secondParentIndex][0] && _values[secondParentIndex][1] >= _values[firstParentIndex][0])
                {
                    return true;
                }

                return false;
            }

            public int GetResult()
            {
                var set = new HashSet<int>();
                var n = _parents.Count();
                for (int i = 0; i < n; i++)
                {
                    set.Add(Find(i));
                }

                var res = 0;
                foreach (var item in set)
                {
                    var value = _values[item];
                    res += value[1] - value[0];
                }

                return res;
            }


        }
    }
}
