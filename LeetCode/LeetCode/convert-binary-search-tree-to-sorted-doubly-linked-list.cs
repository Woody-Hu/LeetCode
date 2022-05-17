using System;
namespace LeetCode
{
    public class convert_binary_search_tree_to_sorted_doubly_linked_list
    {
        public Node TreeToDoublyList(Node root)
        {
            if (root == null)
            {
                return null;
            }

            Node small = null;
            Node current = null;
            Visit(root, ref small, ref current);
            current.right = small;
            small.left = current;
            return small;
        }

        private void Visit(Node root, ref Node small, ref Node current)
        {
            if (root == null)
            {
                return;
            }

            Visit(root.left, ref small, ref current);
            if (current != null)
            {
                current.right = root;
                root.left = current;
            }
            else
            {
                small = current;
            }

            current = root;
            Visit(root.right, ref small, ref current);
        }

        public class Node
        {
            public int val;
            public Node left;
            public Node right;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
                left = null;
                right = null;
            }

            public Node(int _val, Node _left, Node _right)
            {
                val = _val;
                left = _left;
                right = _right;
            }
        }
    }
}
