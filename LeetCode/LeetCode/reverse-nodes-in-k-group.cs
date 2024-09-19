namespace LeetCode;

public class reverse_nodes_in_k_group
{
    public ListNode ReverseKGroup(ListNode head, int k) {
        var dummy = new ListNode(0);
        dummy.next = head;
        var pre = dummy;
        while (head != null) {
            var tail = pre;
            for (int i = 0; i < k; i++) {
                tail = tail.next;
                if (tail == null) {
                    return dummy.next;
                }
            }
            
            var nex = tail.next;
            var res = ReverseInternal(head, tail);
            head = res[0];
            tail = res[1];
            pre.next = head;
            tail.next = nex;
            pre = tail;
            head = tail.next;
        }
        
        return dummy.next;
    }
    
    public ListNode[] ReverseInternal(ListNode head, ListNode tail) {
        var prev = tail.next;
        var p = head;
        while (prev != tail) {
            ListNode nex = p.next;
            p.next = prev;
            prev = p;
            p = nex;
        }
        
        return new ListNode[]{tail, head};
    }
}