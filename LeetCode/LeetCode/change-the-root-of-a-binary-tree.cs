using System;
namespace LeetCode
{
    public class change_the_root_of_a_binary_tree
    {
        public Node FlipBinaryTree(Node root, Node leaf)
        {
            FlipBinaryTreae(leaf, root);
            leaf.parent = null;
            return leaf;
        }

        public void FlipBinaryTreae(Node input, Node root)
        {
            if (input == root)
            {
                return;
            }

            var left = input.left;
            var parent = input.parent;
            if (left != null)
            {
                input.right = left;
            }

            input.left = parent;
            if (parent.left == input)
            {
                parent.left = null;
            }
            else if (parent.right == input)
            {
                parent.right = null;
            }

            FlipBinaryTreae(parent, root);
            parent.parent = input;
        }

        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node parent;
        }
    }
}
