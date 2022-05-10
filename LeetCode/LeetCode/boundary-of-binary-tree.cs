using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class boundary_of_binary_tree
    {
        public IList<int> BoundaryOfBinaryTree(TreeNode root)
        {
            var rootList = new List<int>();
            var leftList = new List<int>();
            var leaveList = new List<int>();
            var rightList = new List<int>();
            Visit(root, 0, rootList, leftList, leaveList, rightList);
            var res = new List<int>();
            res.AddRange(rootList);
            res.AddRange(leftList);
            res.AddRange(leaveList);
            res.AddRange(rightList);

            return res;
        }

        private void Visit(TreeNode root, int tag, List<int> rootList, List<int> leftList, List<int> leaveList, List<int> rightList)
        {
            if (root == null)
            {
                return;
            }

            if (tag == 0)
            {
                rootList.Add(root.val);
            }
            else if (tag == 1)
            {
                leftList.Add(root.val);
            }
            else if (tag == 2)
            {
                rightList.Insert(0, root.val);
            }
            else if (root.left == null && root.right == null)
            {
                leaveList.Add(root.val);
            }

            var leftChildTag = 3;
            var rightChildTag = 3;
            if (tag == 0)
            {
                leftChildTag = 1;
                rightChildTag = 2;
            }
            else if (tag == 1)
            {
                leftChildTag = 1;
                rightChildTag = 3;
                if (root.left == null)
                {
                    rightChildTag = 1;
                }
            }
            else if (tag == 2)
            {
                leftChildTag = 3;
                rightChildTag = 2;
                if (root.right == null)
                {
                    leftChildTag = 2;
                }
            }

            Visit(root.left, leftChildTag, rootList, leftList, leaveList, rightList);
            Visit(root.right, rightChildTag, rootList, leftList, leaveList, rightList);
        }
    }
}
