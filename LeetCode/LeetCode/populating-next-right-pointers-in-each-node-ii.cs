using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class populating_next_right_pointers_in_each_node_ii
    {
        public Node Connect(Node root)
        {
            if (root == null)
            {
                return root;
            }

            var queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Any())
            {
                var n = queue.Count();
                Node last = null;
                for (int i = 0; i < n; i++)
                {
                    var current = queue.Dequeue();
                    if (current.left != null)
                    {
                        queue.Enqueue(current.left);
                    }

                    if (current.right != null)
                    {
                        queue.Enqueue(current.right);
                    }

                    if (last != null)
                    {
                        last.next = current;
                    }

                    last = current;
                }
            }

            return root;
        }


        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node next;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, Node _left, Node _right, Node _next)
            {
                val = _val;
                left = _left;
                right = _right;
                next = _next;
            }
        }
    }
}
