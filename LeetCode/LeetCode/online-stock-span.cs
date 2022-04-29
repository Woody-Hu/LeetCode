using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class online_stock_span
    {
        private Stack<int> _values = new Stack<int>();
        private Stack<int> _days = new Stack<int>();

        public int Next(int price)
        {
            var day = 1;
            while (_values.Any() && _values.Peek() <= price)
            {
                var currentValue = _values.Pop();
                day += _days.Pop();
            }

            _values.Push(price);
            _days.Push(day);

            return day;
        }
    }
}
