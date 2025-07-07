using System;
using System.Linq;

namespace LeetCode;

public class longest_subsequence_repeated_k_times
{
     private char[] ans;
    private int ansLen = 0;

    public string LongestSubsequenceRepeatedK(string S, int k) {
        char[] s = S.ToCharArray();

        int[] cnt = new int[26];
        foreach (char c in s) {
            cnt[c - 'a']++;
        }

        System.Text.StringBuilder tmp = new System.Text.StringBuilder();
        for (int i = 25; i >= 0; i--) {
            string c = ((char) ('a' + i)).ToString();
            tmp.Append(string.Concat(Enumerable.Repeat(c, cnt[i] / k)));
        }
        char[] a = tmp.ToString().ToCharArray();

        ans = new char[a.Length];
        Permute(a, k, s);

        return new string(ans, 0, ansLen);
    }

    private void Permute(char[] nums, int k, char[] s) {
        int n = nums.Length;
        char[] path = new char[n];
        bool[] onPath = new bool[n];
        Dfs(0, nums, path, onPath, k, s);
    }

    private void Dfs(int i, char[] nums, char[] path, bool[] onPath, int k, char[] s) {
        if (i > 0 && !Process(path, i, k, s)) {
            return;
        }

        if (i == nums.Length) {
            return;
        }

        for (int j = 0; j < nums.Length; j++) {
            if (onPath[j] || j > 0 && nums[j] == nums[j - 1] && !onPath[j - 1]) {
                continue;
            }
            path[i] = nums[j];
            onPath[j] = true;
            Dfs(i + 1, nums, path, onPath, k, s);
            onPath[j] = false;
        }
    }

    private bool Process(char[] seq, int seqLen, int k, char[] s) {
        if (!IsSubsequence(seq, seqLen, k, s)) {
            return false;
        }
        if (seqLen > ansLen || seqLen == ansLen && Compare(seq, ans, ansLen) > 0) {
            Array.Copy(seq, 0, ans, 0, seqLen);
            ansLen = seqLen;
        }
        return true;
    }

    private int Compare(char[] a, char[] b, int n) {
        for (int i = 0; i < n; i++) {
            if (a[i] != b[i]) {
                return a[i] - b[i];
            }
        }
        return 0;
    }

    private bool IsSubsequence(char[] seq, int n, int k, char[] s) {
        int i = 0;
        foreach (char c in s) {
            if (seq[i % n] == c) {
                i++;
                if (i == n * k) {
                    return true;
                }
            }
        }
        return false;
    }
}