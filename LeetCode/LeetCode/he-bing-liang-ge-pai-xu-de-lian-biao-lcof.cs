namespace LeetCode;

public class he_bing_liang_ge_pai_xu_de_lian_biao_lcof
{
    public ListNode TrainningPlan(ListNode l1, ListNode l2)
    {
        var pre = new ListNode(-1);
        var cur = pre;
        while (l1 != null && l2 != null)
        {
            if (l1.val <= l2.val)
            {
                cur.next = l1;
                l1 = l1.next;
            }
            else
            {
                cur.next = l2;
                l2 = l2.next;
            }

            cur = cur.next;
        }
        
        cur.next = l1 ?? l2;
        return pre.next;
    }
}