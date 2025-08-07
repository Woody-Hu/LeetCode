using System.Collections.Generic;

namespace LeetCode;

public class ntersection_of_two_linked_lists_lcci
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        var set = new HashSet<ListNode>();
        while (headA != null)
        {
            set.Add(headA);
            headA = headA.next;
        }

        while (headB != null)
        {
            if (set.Contains(headB))
            {
                return headB;
            }

            headB = headB.next;
        }

        return null;

    }
}