using System.Collections.Generic;

namespace LeetCode;

public class find_occurrences_of_an_element_in_an_array
{
    public int[] OccurrencesOfElement(int[] nums, int[] queries, int x) {
        var indexes = new List<int>();
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == x) {
                indexes.Add(i);
            }
        }
        
        var result = new int[queries.Length];
        for (int i = 0; i < queries.Length; i++) {
            var query = queries[i];
            if (query > indexes.Count)
            {
                result[i] = -1;
            }
            else
            {
                result[i] = indexes[query - 1];
            }
        }
        
        return result;
    }
}