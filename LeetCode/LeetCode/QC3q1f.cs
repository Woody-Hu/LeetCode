using System.Collections.Generic;

namespace LeetCode;

public class QC3q1f
{
    public class Trie {
        private bool isEnd;
        private IDictionary<char, Trie> children;

        public Trie() {
            isEnd = false;
            children = new Dictionary<char, Trie>();
        }

        public void Insert(string word) {
            Trie node = this;
            int length = word.Length;
            for (int i = 0; i < length; i++) {
                char c = word[i];
                node.children.TryAdd(c, new Trie());
                node = node.children[c];
            }
            node.isEnd = true;
        }

        public bool Search(string word) {
            Trie node = SearchPrefix(word);
            return node != null && node.isEnd;
        }

        public bool StartsWith(string prefix) {
            Trie node = SearchPrefix(prefix);
            return node != null;
        }

        private Trie SearchPrefix(string prefix) {
            Trie node = this;
            int length = prefix.Length;
            for (int i = 0; i < length; i++) {
                char c = prefix[i];
                if (!node.children.ContainsKey(c)) {
                    return null;
                }
                node = node.children[c];
            }
            return node;
        }
    }
}