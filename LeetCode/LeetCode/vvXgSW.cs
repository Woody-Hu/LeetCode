using System.Collections.Generic;

namespace LeetCode;

public class vvXgSW
{
    public ListNode MergeKLists(ListNode[] lists){
        if (lists.Length == 0) {
            return null;
        }
        ListNode dummyHead = new ListNode(0);
        PriorityQueue<ListNode, int> pq = new PriorityQueue<ListNode, int>();
        foreach (ListNode head in lists) {
            if (head != null) {
                pq.Enqueue(head, head.val);
            }
        }
        ListNode temp = dummyHead;
        while (pq.Count > 1) {
            ListNode node = pq.Dequeue();
            temp.next = node;
            temp = temp.next;
            node = node.next;
            if (node != null) {
                pq.Enqueue(node, node.val);
            }
        }
        if (pq.Count > 0) {
            temp.next = pq.Dequeue();
        }
        return dummyHead.next;
    }
}