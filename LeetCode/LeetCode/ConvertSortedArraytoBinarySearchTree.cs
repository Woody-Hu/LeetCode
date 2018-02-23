using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ConvertSortedArraytoBinarySearchTree
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Length == 0)
            {
                return null;
            }

            return GetNodeLoop(nums, 0, nums.Length - 1);
        }

        private TreeNode GetNodeLoop(int[] inputNums,int indexOne,int indexTwo)
        {
            if (indexOne > indexTwo)
            {
                return null;
            }

            int tempIndex = (indexOne + indexTwo) / 2;

            int tempValue = inputNums[tempIndex];

            TreeNode tempTreeNode = new TreeNode(tempValue);

            tempTreeNode.left = GetNodeLoop(inputNums, indexOne, tempIndex - 1);
            tempTreeNode.right = GetNodeLoop(inputNums, tempIndex + 1, indexTwo);

            return tempTreeNode;
 
        }
    }
}
