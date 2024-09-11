using System;
using System.Collections.Generic;

namespace LeetCode;

public class p8L0Z {
    public IList<IList<int>> PermuteUnique(int[] nums) {

        var res = new List<IList<int>>();
        var temp = new List<int>();
        var visited = new bool[nums.Length];
        Array.Sort(nums);
        
        Backtrack(nums, res, temp, visited);
        return res;

    }
    
    private void Backtrack(int[] nums, List<IList<int>> res, List<int> temp, bool[] visited) {
        if (temp.Count == nums.Length) {
            res.Add(new List<int>(temp));
            return;
        }
        
        for (int i = 0; i < nums.Length; i++) {
            if (visited[i] || i > 0 && nums[i] == nums[i - 1] && !visited[i - 1]) {
                continue;
            }
            
            visited[i] = true;
            temp.Add(nums[i]);
            Backtrack(nums, res, temp, visited);
            visited[i] = false;
            temp.RemoveAt(temp.Count - 1);
        }
    }
    
}