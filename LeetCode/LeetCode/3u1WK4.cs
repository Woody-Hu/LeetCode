using System.Collections.Generic;

namespace LeetCode;

public class u1WK4 {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        var set = new HashSet<ListNode>();
        while (headA != null) {
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