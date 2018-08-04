using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class KthLargestElementinaStream
    {
        private InnerTree root;
        private int k;

        private bool isInitialized;

        public KthLargestElementinaStream(int k, int[] nums)
        {
            this.k = k;

            foreach (var oneValue in nums)
            {
                Add(oneValue);
            }
            isInitialized = true;
        }

        public int Add(int val)
        {
            if (root == null)
                root = new InnerTree(val);
            else
            {
                InnerTree walker = root;

                while (walker != null)
                {
                    walker.count++;
                    if (val < walker.val)
                    {
                        if (walker.left != null)
                            walker = walker.left;
                        else
                        {
                            walker.left = new InnerTree(val);
                            break;
                        }
                    }
                    else
                    {
                        if (walker.right != null)
                            walker = walker.right;
                        else
                        {
                            walker.right = new InnerTree(val);
                            break;
                        }
                    }
                }
            }

            if (!isInitialized)
            {
                return -1;
            }

            InnerTree kNode = findKthLargestNode();
            return kNode.val;


        }

        private InnerTree findKthLargestNode()
        {
            int counter = k;
            InnerTree walker = root;

            while (walker != null && counter > 0)
            {
                int pos = (walker.right == null ? 1 : walker.right.count + 1);
                if (counter == pos)
                {
                    break;
                }
                else if (counter > pos)
                {
                    counter -= pos;
                    walker = walker.left;
                }
                else
                    walker = walker.right;
            }

            return walker;
        }

        private class InnerTree
        {
            public int val;
            public int count;
            public InnerTree left;
            public InnerTree right;
            internal InnerTree(int _val)
            {
                count = 1;
                val = _val;
            }
        }

    }
}
