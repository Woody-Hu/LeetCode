using System.Collections.Generic;

namespace LeetCode;

public class UhWRSj
{
    public string ReplaceWords(IList<string> dictionary, string sentence) {
        var root = new TrieNode();
        foreach (var word in dictionary) {
            var node = root;
            foreach (var ch in word) {
                if (node.Children[ch - 'a'] == null) {
                    node.Children[ch - 'a'] = new TrieNode();
                }
                node = node.Children[ch - 'a'];
            }
            node.IsWord = true;
        }
        
        var words = sentence.Split(' ');
        for (var i = 0; i < words.Length; i++) {
            var word = words[i];
            var node = root;
            var prefix = "";
            foreach (var ch in word) {
                if (node.Children[ch - 'a'] == null) {
                    break;
                }
                node = node.Children[ch - 'a'];
                prefix += ch;
                if (node.IsWord) {
                    words[i] = prefix;
                    break;
                }
            }
        }
        
        return string.Join(" ", words);
    }
    
    public class TrieNode {
        public TrieNode[] Children;
        public bool IsWord;
        
        public TrieNode() {
            Children = new TrieNode[26];
        }
    }
}