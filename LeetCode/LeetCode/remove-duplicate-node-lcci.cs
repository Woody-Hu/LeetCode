using System.Collections.Generic;

namespace LeetCode;

public class remove_duplicate_node_lcci
{
    public ListNode RemoveDuplicateNodes(ListNode head) {
        if (head == null) return null;

        var seen = new HashSet<int>();
        seen.Add(head.val);
        var current = head;

        while (current.next != null) {
            if (seen.Contains(current.next.val)) {
                current.next = current.next.next; // Skip the duplicate node
            } else {
                seen.Add(current.next.val);
                current = current.next; // Move to the next node
            }
        }

        return head; // Return the modified list
        
    }
}