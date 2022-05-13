using System;
namespace LeetCode
{
    public class sort_linked_list_already_sorted_using_absolute_values
    {
        public ListNode SortLinkedList(ListNode head)
        {
            var resHead = new ListNode(0);
            resHead.next = head;
            var current = resHead;
            while (current.next != null)
            {
                if (current.next.val < 0 && current.next != head)
                {
                    var nextnext = current.next.next;
                    var next = current.next;
                    var resNext = resHead.next;
                    current.next = nextnext;
                    next.next = resNext;
                    resHead.next = next;
                }
                else
                { current = current.next; }
            }

            return resHead.next;
        }
    }
}
