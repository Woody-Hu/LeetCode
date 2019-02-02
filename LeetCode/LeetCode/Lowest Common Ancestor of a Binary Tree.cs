using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Lowest_Common_Ancestor_of_a_Binary_Tree
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null || p == null || q == null)
            {
                return null;
            }

            var pathQ = new List<TreeNode>();
            var pathP = new List<TreeNode>();
            FindPath(root, p, pathP);
            FindPath(root, q, pathQ);

            var minPath = Math.Min(pathP.Count, pathQ.Count);
            var index = 0;

            for (int i = 0; i < minPath; i++)
            {
                if (pathP[i] == pathQ[i])
                {
                    index = i;
                }
            }

            return pathQ[index];
        }

        private bool FindPath(TreeNode root, TreeNode node, IList<TreeNode> path)
        {
            if (root == null)
                return false;
            path.Add(root);
            if (root.val == node.val)
                return true;
            if (FindPath(root.left, node, path) || FindPath(root.right, node, path))
                return true;
            path.RemoveAt(path.Count - 1);
            return false;
        }
    }
}
