using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LeetCode
{
    class Print_in_Order
    {
        private int _count = 0;

        public Print_in_Order()
        {

        }

        public void First(Action printFirst)
        {
            SpinWait.SpinUntil(() => _count == 0);
            // printFirst() outputs "first". Do not change or remove this line.
            printFirst();
            _count++;
        }

        public void Second(Action printSecond)
        {
            SpinWait.SpinUntil(() => _count == 1);
            // printSecond() outputs "second". Do not change or remove this line.
            printSecond();
            _count++;
        }

        public void Third(Action printThird)
        {
            SpinWait.SpinUntil(() => _count == 2);
            // printThird() outputs "third". Do not change or remove this line.
            printThird();
        }
    }
}
