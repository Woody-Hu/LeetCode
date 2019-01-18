using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Trie
    {
        private TrieNode root;

        /** Initialize your data structure here. */
        public Trie()
        {
            root = new TrieNode
            {
                Val = ' '
            };
        }

        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            TrieNode ws = root;
            foreach (var c in word)
            {
                if (ws.ChildrenNodes[c - 'a'] == null)
                {
                    ws.ChildrenNodes[c - 'a'] = new TrieNode(c);
                }
                ws = ws.ChildrenNodes[c - 'a'];
            }
            ws.IsWord = true;
        }

        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            TrieNode ws = root;
            foreach (var c in word)
            {
                if (ws.ChildrenNodes[c - 'a'] == null) return false;
                ws = ws.ChildrenNodes[c - 'a'];
            }
            return ws.IsWord;
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix)
        {
            TrieNode ws = root;
            foreach (var c in prefix)
            {
                if (ws.ChildrenNodes[c - 'a'] == null) return false;
                ws = ws.ChildrenNodes[c - 'a'];
            }
            return true;
        }

        private class TrieNode
        {
            public char Val;
            public bool IsWord;
            public TrieNode[] ChildrenNodes = new TrieNode[26];
            public TrieNode() { }
            public TrieNode(char c)
            {
                TrieNode node = new TrieNode();
                node.Val = c;
            }
        }
    }
}
