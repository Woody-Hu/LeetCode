using System.Collections.Generic;
using System.Linq;

namespace LeetCode;

public class H97ZC {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
        var dict = new Dictionary<int, int>();
        foreach (var num in arr1) {
            if (dict.ContainsKey(num)) {
                dict[num]++;
            } else {
                dict[num] = 1;
            }
        }
        
        var result = new List<int>();
        foreach (var num in arr2) {
            if (dict.ContainsKey(num)) {
                for (int i = 0; i < dict[num]; i++) {
                    result.Add(num);
                }
                dict.Remove(num);
            }
        }
        
        var remaining = dict.Keys.ToList();
        remaining.Sort();
        foreach (var num in remaining) {
            for (int i = 0; i < dict[num]; i++) {
                result.Add(num);
            }
        }
        
        return result.ToArray();

    }
}