using System.Collections.Generic;

namespace LeetCode;

public class ms70jA
{
    const int HIGH_BIT = 30;

    public int FindMaximumXOR(int[] nums) {
        int x = 0;
        for (int k = HIGH_BIT; k >= 0; --k) {
            ISet<int> seen = new HashSet<int>();
            foreach (int num in nums) {
                seen.Add(num >> k);
            }

            int xNext = x * 2 + 1;
            bool found = false;
            
            foreach (int num in nums) {
                if (seen.Contains(xNext ^ (num >> k))) {
                    found = true;
                    break;
                }
            }

            if (found) {
                x = xNext;
            } else {
                x = xNext - 1;
            }
        }
        return x;
    }
}