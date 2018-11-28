using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ConvertSortedListtoBinarySearchTree
    {
        public TreeNode SortedListToBST(ListNode head)
        {
            List<int> values = new List<int>();
            ListNode node = head;
            while (null != node)
            {
                values.Add(node.val);
                node = node.next;
            }

            var endIndex = values.Count - 1;

            return SortedListToBST(values, 0, endIndex);
        }

        private TreeNode SortedListToBST(List<int> values, int startIndex, int endIndex)
        {
            if (startIndex > endIndex)
            {
                return null;
            }

            if (startIndex == endIndex)
            {
                return new TreeNode(values[startIndex]);
            }

            var mid = startIndex + (endIndex - startIndex) / 2;

            TreeNode node = new TreeNode(values[mid]);
            node.left = SortedListToBST(values, startIndex, mid - 1);
            node.right = SortedListToBST(values, mid+1, endIndex);

            return node;
        }
    }
}
