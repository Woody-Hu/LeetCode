using System;
namespace LeetCode
{
    public class Populating_Next_Right_Pointers_in_Each_Node
    {
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


        public Node Connect(Node root)
        {
            if (root == null)
            {
                return null;
            }

            var level_start = root;
            while (level_start != null)
            {
                var cur = level_start;
                while (cur != null)
                {
                    if (cur.left != null) cur.left.next = cur.right;
                    if (cur.right != null && cur.next != null) cur.right.next = cur.next.left;

                    cur = cur.next;
                }
                level_start = level_start.left;
            }

            return root;
        }
    }
}
