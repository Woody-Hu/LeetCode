using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class my_calendar_i
    {
        public class MyCalendar
        {
            private readonly List<(int, int)> _values = new List<(int, int)>();

            public MyCalendar()
            {

            }

            public bool Book(int start, int end)
            {
                foreach (var item in _values)
                {
                    if (start < item.Item2 && item.Item1 < end)
                    {
                        return false;
                    }
                }

                _values.Add((start, end));
                return true;
            }
        }
    }
}
