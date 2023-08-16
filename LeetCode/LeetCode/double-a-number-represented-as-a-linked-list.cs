using System;
namespace LeetCode
{
	public class double_a_number_represented_as_a_linked_list
	{
        public ListNode DoubleIt(ListNode head)
        {
            if (head.val > 4)
            {
                var temp = head;
                head = new ListNode(0);
                head.next = temp;
            }

            var current = head;
            while (current != null)
            {
                current.val = current.val * 2 % 10;
                if (current.next != null && current.next.val > 4)
                {
                    current.val++;
                }

                current = current.next;
            }

            return head;
        }
    }
}

