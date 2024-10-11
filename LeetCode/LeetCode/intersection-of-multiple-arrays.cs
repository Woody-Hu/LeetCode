using System.Collections.Generic;

namespace LeetCode;

public class intersection_of_multiple_arrays
{
    public IList<int> Intersection(int[][] nums) {
        
        var list = new List<int>();
        IDictionary<int, int> counts = new Dictionary<int, int>();
        int numArrays = nums.Length;
        foreach (int[] arr in nums) {
            foreach (int num in arr) {
                counts.TryAdd(num, 0);
                counts[num]++;
            }
        }
        
        foreach (KeyValuePair<int, int> pair in counts) {
            if (pair.Value == numArrays) {
                list.Add(pair.Key);
            }
        }
        
        list.Sort();
        return list;

    }
}