using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class ShortEncodingofWords
    {
        class InnerTireTree
        {
            internal InnerNode rootNode = new InnerNode();

            internal void AddString(string input)
            {
                InnerNode useNode = rootNode;
                for (int i = input.Length - 1; i >=0; i--)
                {
                    var tempChar = input[i];
                    var tempIndex = tempChar - 'a';

                    if (null == useNode.SubNodes[tempIndex])
                    {
                        useNode.SubNodes[tempIndex] = new InnerNode();
                    }

                    useNode = useNode.SubNodes[tempIndex];
                }

                useNode.ifIsEnd = true;
            }
        }

        class InnerNode
        {
            internal bool ifIsEnd = false;

            internal InnerNode[] SubNodes = new InnerNode[26];

        }

        private InnerTireTree m_useTree = new InnerTireTree();

        public int MinimumLengthEncoding(string[] words)
        {
            foreach (var oneStr in words)
            {
                m_useTree.AddString(oneStr);
            }

            return GetLength(m_useTree.rootNode, 0);
        }

        private int GetLength(InnerNode inputNode,int inputLength)
        {
            if (null == inputNode)
            {
                return 0;
            }

            bool hasSubValue = false;

            int useLengthValue = 0;

            foreach (var oneSubNode in inputNode.SubNodes)
            {
                if (null != oneSubNode)
                {
                    hasSubValue = true;

                    useLengthValue += GetLength(oneSubNode, inputLength + 1);
                }
            }

            return hasSubValue ? useLengthValue : inputLength + 1;

        }
    }
}
