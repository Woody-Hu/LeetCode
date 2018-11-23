using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class BinaryTreeZigzagLevelOrderTraversal
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            if (null == root)
            {
                return new List<IList<int>>();
            }

            IList<IList<int>> returnValue = new List<IList<int>>();

            Queue<TreeNode> useQueue = new Queue<TreeNode>();
            Queue<TreeNode> anotherQueue = new Queue<TreeNode>();

            useQueue.Enqueue(root);

            List<int> useList = new List<int>();

            bool ifLeftToRight = true;

            while (useQueue.Count != 0)
            {
                var node = useQueue.Dequeue();
                useList.Add(node.val);

                if (ifLeftToRight)
                {
                    if (null != node.left)
                    {
                        anotherQueue.Enqueue(node.left);
                    }
                    if (null != node.right)
                    {
                        anotherQueue.Enqueue(node.right);
                    }
                }
                else
                {
                    if (null != node.right)
                    {
                        anotherQueue.Enqueue(node.right);
                    }
                    if (null != node.left)
                    {
                        anotherQueue.Enqueue(node.left);
                    }

                }
        

                if (useQueue.Count == 0)
                {
                    var tempQueue = useQueue;
                    useQueue = anotherQueue;
                    anotherQueue = tempQueue;
                    returnValue.Add(useList);
                    useList = new List<int>();
                    ifLeftToRight = !ifLeftToRight;
                    useQueue = new Queue<TreeNode>(useQueue.Reverse());
                }
            }

            return returnValue;
        }
    }
}
