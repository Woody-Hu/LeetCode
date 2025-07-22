using System.Collections.Generic;

namespace LeetCode;

public class delete_duplicate_folders_in_system
{
    class Trie {
        public string Serial { get; set; } = ""; // 当前节点结构的序列化表示
        public Dictionary<string, Trie> Children { get; } = new Dictionary<string, Trie>(); // 当前节点的子节点
    }

    public IList<IList<string>> DeleteDuplicateFolder(IList<IList<string>> paths) {
        Trie root = new Trie();
        foreach (var p in paths) {
            Trie current = root;
            foreach (var node in p) {
                if (!current.Children.ContainsKey(node)) {
                    current.Children[node] = new Trie();
                }
                current = current.Children[node];
            }
        }
        
        var freq = new Dictionary<string, int>();
        
        void Construct(Trie node) {
            if (node.Children.Count == 0) {
                return;
            }
            var v = new List<string>();
            foreach (var entry in node.Children) {
                Construct(entry.Value);
                v.Add($"{entry.Key}({entry.Value.Serial})");
            }
            v.Sort();
            node.Serial = string.Join("", v);
            if (!freq.ContainsKey(node.Serial)) {
                freq[node.Serial] = 0;
            }
            freq[node.Serial]++;
        }

        Construct(root);
        var ans = new List<IList<string>>();
        var path = new List<string>();
        void Operate(Trie node) {
            if (freq.TryGetValue(node.Serial, out int count) && count > 1) {
                return;
            }
            if (path.Count > 0) {
                ans.Add(new List<string>(path));
            }

            foreach (var entry in node.Children) {
                path.Add(entry.Key);
                Operate(entry.Value);
                path.RemoveAt(path.Count - 1);
            }
        }

        Operate(root);
        return ans;
    }
}