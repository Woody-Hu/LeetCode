using System.Collections.Generic;

namespace LeetCode;

public class minimum_number_of_operations_to_make_array_empty
{
    public int MinOperations(int[] nums) {
        var cnt = new Dictionary<int, int>();
        foreach (int x in nums) {
            if (cnt.ContainsKey(x)) {
                cnt[x]++;
            } else {
                cnt[x] = 1;
            }
        }
        int ans = 0;
        foreach (int c in cnt.Values) {
            if (c == 1) {
                return -1;
            }
            ans += (c + 2) / 3;
        }
        return ans;
    }
}