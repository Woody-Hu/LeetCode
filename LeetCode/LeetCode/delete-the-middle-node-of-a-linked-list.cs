using System;
namespace LeetCode
{
	public class delete_the_middle_node_of_a_linked_list
	{
        public ListNode DeleteMiddle(ListNode head)
        {
            if (head.next == null)
            {
                return null;
            }

            var slow = head;
            var fast = head;
            ListNode pre = null;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                pre = slow;
                slow = slow.next;
            }

            pre.next = pre.next.next;
            return head;
        }
    }
}

