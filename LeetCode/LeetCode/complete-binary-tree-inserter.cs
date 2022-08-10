using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class complete_binary_tree_inserter
    {
        public class CBTInserter
        {
            private TreeNode _root;

            private Queue<TreeNode> _queue = new Queue<TreeNode>();

            public CBTInserter(TreeNode root)
            {
                _root = root;
                var queue = new Queue<TreeNode>();
                queue.Enqueue(root);
                while (queue.Count > 0)
                {
                    var node = queue.Dequeue();
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }

                    if (!(node.left != null && node.right != null))
                    {
                        _queue.Enqueue(node);
                    }
                }

            }

            public int Insert(int val)
            {
                var node = new TreeNode(val);
                var parent = _queue.Peek();
                var res = parent.val;
                if (parent.left == null)
                {
                    parent.left = node;
                }
                else
                {
                    parent.right = node;
                    _queue.Dequeue();
                }

                _queue.Enqueue(node);
                return res;

            }

            public TreeNode Get_root()
            {
                return _root;
            }
        }
    }
}
