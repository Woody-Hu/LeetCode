using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Maximum_XOR_of_Two_Numbers_in_an_Array
    {
        public int FindMaximumXOR(int[] nums)
        {
            TrieNode root = new TrieNode();
            foreach (var num in nums)
            {
                TrieNode cur = root;
                for (int i = 31; i >= 0; i--)
                {
                    int bit = (num >> i) & 1;
                    if (cur.children[bit] == null)
                    {
                        cur.children[bit] = new TrieNode();
                    }
                    cur = cur.children[bit];
                }
            }

            int max = int.MinValue;
            foreach (var num in nums)
            {
                TrieNode cur = root;
                int xorValue = 0;
                for (int i = 31; i >= 0; i--)
                {
                    int bit = (num >> i) & 1;
                    if (cur.children[bit == 1 ? 0 : 1] != null)
                    {
                        xorValue += (1 << i);
                        cur = cur.children[bit == 1 ? 0 : 1];
                    }
                    else
                    {
                        cur = cur.children[bit];
                    }
                }
                max = Math.Max(xorValue, max);
            }


            return max;
        }

        private class TrieNode
        {
            public TrieNode[] children;
            public TrieNode()
            {
                children = new TrieNode[2];
            }
        }
    }
}
