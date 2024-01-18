using System;
namespace LeetCode
{
	public class fan_zhuan_lian_biao_lco
	{
        public ListNode TrainningPlan(ListNode head)
        {
            var cur = head;
            ListNode pre = null;
            while (cur != null)
            {
                var temp = cur.next;
                cur.next = pre;
                pre = cur;
                cur = temp;
            }

            return pre;
        }
    }
}

