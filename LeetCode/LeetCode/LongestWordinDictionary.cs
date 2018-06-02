using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class LongestWordinDictionary
    {
        class Tire
        {
            Node useRoot;

            internal Tire()
            {
                useRoot = new Node();
                useRoot.IfIsEnd = true;
            }

            internal void Insert(string input)
            {
                Node useNode = useRoot;

                foreach (var oneChar in input)
                {
                    if (null == useNode.subNodes[oneChar -'a'])
                    {
                        useNode.subNodes[oneChar - 'a'] = new Node();
                    }

                    useNode = useNode.subNodes[oneChar - 'a'];
                }
                useNode.IfIsEnd = true;
            }

            internal bool Check(string input)
            {
                Node useNode = useRoot;
                foreach (var oneChar in input)
                {
                    if (null == useNode.subNodes[oneChar - 'a'] || !useNode.subNodes[oneChar - 'a'].IfIsEnd)
                    {
                        return false;
                    }
                    useNode = useNode.subNodes[oneChar - 'a'];
                }
                return true;

            }

        }

        class Node
        {
            public Node[] subNodes = new Node[26];

            public bool IfIsEnd = false;
        }

        public string LongestWord(string[] words)
        {

            Tire useTire = new Tire();

            foreach (var oneWord in words)
            {
                useTire.Insert(oneWord);
            }

            string returnValue = string.Empty;

            foreach (var oneWord in words)
            {
                if (useTire.Check(oneWord))
                {
                    if (oneWord.Length > returnValue.Length)
                    {
                        returnValue = oneWord;
                    }
                    else if (oneWord.Length == returnValue.Length && oneWord.CompareTo(returnValue) < 0)
                    {
                        returnValue = oneWord;
                    }
                }
            }

            return returnValue;
        }


    }
}
