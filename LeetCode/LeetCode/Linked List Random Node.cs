using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Linked_List_Random_Node
    {
        private ListNode _head;
        private Random _random;

        public Linked_List_Random_Node(ListNode head)
        {
            _head = head;
            _random = new Random();
        }

        public int GetRandom()
        {
            var current = _head;
            var value = current.val;
            var index = 0;
            while (current != null)
            {
                if (_random.Next(index+1) == index)
                {
                    value = current.val;
                }

                current = current.next;
                index++;
            }

            return value;

        }
    }
}
