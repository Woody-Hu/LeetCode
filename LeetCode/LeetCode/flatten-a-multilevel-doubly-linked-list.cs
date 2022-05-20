using System;
namespace LeetCode
{
	public class flatten_a_multilevel_doubly_linked_list
	{
        public Node Flatten(Node head)
        {
            if (head == null)
            {
                return head;
            }

            FlatternAndReturnLast(head);
            return head;
        }

        private Node FlatternAndReturnLast(Node head)
        {
            var current = head;
            Node last = null;
            while (current != null)
            {
                var next = current.next;
                if (current.child != null)
                {
                    var childLast = FlatternAndReturnLast(current.child);
                    current.next = current.child;
                    current.child.prev = current;
                    childLast.next = next;
                    if (next != null)
                    {
                        next.prev = childLast;
                    }

                    current.child = null;
                    last = childLast;
                }
                else
                {
                    last = current;
                }

                current = next;
            }

            return last;
        }

        public class Node
        {
            public int val;
            public Node prev;
            public Node next;
            public Node child;
        }
    }
}

