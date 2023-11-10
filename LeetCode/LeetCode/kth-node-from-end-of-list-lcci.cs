using System;
namespace LeetCode
{
	public class kth_node_from_end_of_list_lcci
	{
        public int KthToLast(ListNode head, int k)
        {
            var pre = head;
            var cur = head;
            for (int i = 0; i < k; i++)
            {
                cur = cur.next;
            }

            while (cur != null)
            {
                cur = cur.next;
                pre = pre.next;
            }

            return pre.val;
        }
    }
}

