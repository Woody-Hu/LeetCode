using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class WordDictionary
    {
        private TrieNode _root;

        public WordDictionary()
        {
            _root = new TrieNode();
        }

        /** Adds a word into the data structure. */
        public void AddWord(string word)
        {
            var useNode = _root;
            foreach (var oneChar in word)
            {
                if (useNode.SubArray[oneChar - 'a'] == null)
                {
                    useNode.SubArray[oneChar - 'a'] = new TrieNode();
                }
                useNode = useNode.SubArray[oneChar - 'a'];
            }

            useNode.Item = word;
        }

        /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
        public bool Search(string word)
        {
            return Search(word.ToCharArray(), 0, _root);
        }

        private bool Search(char[] word, int index, TrieNode tireNode)
        {
            if (index == word.Length)
            {
                return tireNode.Item != "";
            }

            if (word[index] != '.')
            {
                return tireNode.SubArray[word[index] - 'a'] != null &&
                       Search(word, index + 1, tireNode.SubArray[word[index] - 'a']);
            }
            else
            {
                foreach (var oneSubNode in tireNode.SubArray)
                {
                    if (oneSubNode == null)
                    {
                        continue;
                    }

                    if (Search(word,index+1,oneSubNode))
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        private class TrieNode
        {
            internal TrieNode[] SubArray = new TrieNode[26];
            internal string Item = string.Empty;
        }
    }
}
