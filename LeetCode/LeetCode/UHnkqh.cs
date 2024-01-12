using System;
namespace LeetCode
{
	public class UHnkqh
	{
        public ListNode ReverseList(ListNode head)
        {
            ListNode pre = null;
            var curr = head;
            while (curr != null)
            {
                var next = curr.next;
                curr.next = pre;
                pre = curr;
                curr = next;
            }

            return pre;
        }
    }
}

