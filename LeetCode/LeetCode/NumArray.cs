using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class NumArray
    {
        class innerTreeNode
        {
            internal int startIndex;

            internal int endIndex;

            internal innerTreeNode LeftNode;

            internal innerTreeNode RightNode;

            internal int sum;
        }

        private innerTreeNode m_rootNode;



        public NumArray(int[] nums)
        {
            m_rootNode = BuiltTree(nums, 0, nums.Length - 1);
        }

        public void Update(int i, int val)
        {
            Update(m_rootNode, i, val);
        }

        public int SumRange(int i, int j)
        {
            return CalculateSum(m_rootNode, i, j);
        }

        private innerTreeNode BuiltTree(int[] nums,int startIndex,int endIndex)
        {
            if (startIndex > endIndex)
            {
                return null;
            }
            else
            {
                innerTreeNode returnValue = new innerTreeNode();
                returnValue.startIndex = startIndex;
                returnValue.endIndex = endIndex;

                if (startIndex == endIndex)
                {
                    returnValue.sum = nums[startIndex];
                }
                else
                {
                    int midIndex = startIndex + (endIndex - startIndex) / 2 ;

                    returnValue.LeftNode = BuiltTree(nums, startIndex, midIndex);

                    returnValue.RightNode = BuiltTree(nums, midIndex + 1, endIndex);

                    returnValue.sum = returnValue.LeftNode.sum + returnValue.RightNode.sum;
                }

                return returnValue;
            }
        }

        private void Update(innerTreeNode useNode,int useIndex,int useValue)
        {
            if (useNode.startIndex == useNode.endIndex)
            {
                useNode.sum = useValue;
            }
            else
            {
                int midIndex = useNode.startIndex + (useNode.endIndex - useNode.startIndex) / 2 ;

                if (useIndex <= midIndex)
                {
                    Update(useNode.LeftNode, useIndex, useValue);
                }
                else
                {
                    Update(useNode.RightNode, useIndex, useValue);
                }

                useNode.sum = useNode.LeftNode.sum + useNode.RightNode.sum;
            }
        }

        private int CalculateSum(innerTreeNode useNode,int i, int j)
        {
            if (useNode.startIndex == i && useNode.endIndex == j)
            {
                return useNode.sum;
            }
            else
            {
                int midIndex = useNode.startIndex + (useNode.endIndex - useNode.startIndex) / 2;

                if (j <= midIndex)
                {
                    return CalculateSum(useNode.LeftNode, i, j);
                }
                else if (i >= midIndex + 1)
                {
                    return CalculateSum(useNode.RightNode, i, j);
                }
                else
                {
                    return CalculateSum(useNode.RightNode, midIndex + 1, j) + CalculateSum(useNode.LeftNode, i, midIndex);
                }
            }
        }

    }
}
