using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class even_odd_tree
    {
        public bool IsEvenOddTree(TreeNode root)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int level = 0;
            while (queue.Count > 0)
            {
                var size = queue.Count;
                var levelTag = level % 2;
                var prev = levelTag == 0 ? int.MinValue : int.MaxValue;
                for (int i = 0; i < size; i++)
                {
                    var node = queue.Dequeue();
                    var value = node.val;
                    if (levelTag == value % 2)
                    {
                        return false;
                    }
                    if ((levelTag == 0 && value <= prev) || (levelTag == 1 && value >= prev))
                    {
                        return false;
                    }
                    prev = value;
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
                level++;
            }
            return true;
        }
    }
}
