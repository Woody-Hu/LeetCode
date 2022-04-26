using System;
namespace LeetCode
{
    public class insert_into_a_sorted_circular_linked_list
    {
        public Node Insert(Node head, int insertVal)
        {
            if (head == null)
            {
                var res = new Node(insertVal);
                res.next = res;
                return res;
            }

            var root = head;
            var current = head;
            var next = current.next;
            do
            {
                if (insertVal >= current.val && insertVal <= next.val)
                {
                    var node = new Node(insertVal);
                    current.next = node;
                    node.next = next;
                    return root;
                }
                else if (current.val > next.val)
                {
                    if (insertVal >= current.val || insertVal <= next.val)
                    {
                        var node = new Node(insertVal);
                        current.next = node;
                        node.next = next;
                        return root;
                    }
                }

                current = next;
                next = next.next;

            } while (current != root);

            current.next = new Node(insertVal, current.next);
            return root;

        }

        public class Node
        {
            public int val;
            public Node next;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
                next = null;
            }

            public Node(int _val, Node _next)
            {
                val = _val;
                next = _next;
            }
        }
    }
}
