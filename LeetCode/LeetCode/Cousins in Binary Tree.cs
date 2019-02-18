using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Cousins_in_Binary_Tree
    {
        public bool IsCousins(TreeNode root, int x, int y)
        {
            if (null == root)
            {
                return false;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var depthX = 0;
            var depthY = 0;
            var depth = 0;

            while (queue.Count != 0)
            {
                depth++;
                var length = queue.Count;

                for (int i = 0; i < length; i++)
                {
                    var node = queue.Dequeue();
                    if (node.val == x)
                    {
                        depthX = depth;
                    }
                    else if (node.val == y)
                    {
                        depthY = depth;
                    }

                    if (null != node.left)
                    {
                        queue.Enqueue(node.left);
                    }

                    if (null != node.right)
                    {
                        queue.Enqueue(node.right);
                    }

                    if (null != node.left && null != node.right)
                    {
                        if (node.left.val == x && node.right.val == y)
                        {
                            return false;
                        }
                        else if (node.left.val == y && node.right.val == x)
                        {
                            return false;
                        }
                    }
                }
            }

            return depthY == depthX;
        }
    }
}
