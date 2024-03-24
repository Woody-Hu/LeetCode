using System.Collections.Generic;

namespace LeetCode;

public class fu_za_lian_biao_de_fu_zhi_lcof
{
    public Node CopyRandomList(Node head) {
        if (head == null) return null;
        
        var map = new Dictionary<Node, Node>();
        var cur = head;
        while (cur != null) {
            map[cur] = new Node(cur.val);
            cur = cur.next;
        }
        
        cur = head;
        while (cur != null) {
            if (cur.next != null)
            {
                map[cur].next = map.GetValueOrDefault(cur.next);
            }

            if (cur.random != null)
            {
                map[cur].random = map.GetValueOrDefault(cur.random);
            }
            
            cur = cur.next;
        }
        
        return map[head];
    }
    
    public class Node {
        public int val;
        public Node next;
        public Node random;
    
        public Node(int _val) {
            val = _val;
            next = null;
            random = null;
        }
    }
}