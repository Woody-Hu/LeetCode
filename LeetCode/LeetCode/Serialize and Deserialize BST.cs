using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Serialize_and_Deserialize_BST
    {
        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            return $"{root.val},{serialize(root.left)},{serialize(root.right)}";
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            if (string.IsNullOrWhiteSpace(data))
            {
                return null;
            }

            var strings = data.Split(',');
            TreeNode node = null;
            foreach (var ontString in strings)
            {
                if (string.IsNullOrWhiteSpace(ontString) || ontString == "null")
                {
                    continue;
                }
                node = Insert(node, int.Parse(ontString));
            }

            return node;
        }

        private TreeNode Insert(TreeNode root, int val)
        {
            if (root == null)
            {
                root = new TreeNode(val);
                return root;
            }

            if (val < root.val)
            {
                root.left = Insert(root.left, val);
            }
            else if (val > root.val)
            {
                root.right = Insert(root.right, val);
            }

            return root;
        }
    }
}
