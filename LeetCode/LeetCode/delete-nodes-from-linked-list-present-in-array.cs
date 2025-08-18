using System.Collections.Generic;

namespace LeetCode;

public class delete_nodes_from_linked_list_present_in_array
{
    public ListNode ModifiedList(int[] nums, ListNode head) {
        ISet<int> numsSet = new HashSet<int>();
        foreach (int num in nums) {
            numsSet.Add(num);
        }
        ListNode dummyHead = new ListNode(0);
        dummyHead.next = head;
        ListNode node = dummyHead;
        while (node.next != null) {
            if (numsSet.Contains(node.next.val)) {
                node.next = node.next.next;
            } else {
                node = node.next;
            }
        }
        return dummyHead.next;
    }
    
}