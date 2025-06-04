using System;
using System.Collections.Generic;

namespace LeetCode;

public class sjJUc {
    IList<IList<int>> combinations = new List<IList<int>>();
    IList<int> temp = new List<int>();
    int[] candidates;
    int n;

    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        this.candidates = candidates;
        this.n = candidates.Length;
        Backtrack(0, target);
        return combinations;
    }

    public void Backtrack(int index, int remain) {
        if (remain == 0) {
            combinations.Add(new List<int>(temp));
        } else {
            for (int i = index; i < n && candidates[i] <= remain; i++) {
                if (i > index && candidates[i] == candidates[i - 1]) {
                    continue;
                }
                temp.Add(candidates[i]);
                Backtrack(i + 1, remain - candidates[i]);
                temp.RemoveAt(temp.Count - 1);
            }
        }
    }
}