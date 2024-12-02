namespace LeetCode;

public class liang_ge_lian_biao_de_di_yi_ge_gong_gong_jie_dian_lcof
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        var a = headA;
        var b = headB;
        while (a != b)
        {
            a = a == null ? headB : a.next;
            b = b == null ? headA : b.next;
        }

        return a;
    }
}