using System.Collections.Generic;

namespace LeetCode;

public class restore_finishing_order
{
    public int[] RecoverOrder(int[] order, int[] friends) {
        var res = new List<int>(friends.Length);
        var set = new HashSet<int>(friends);
        foreach (var o in order) {
            if (set.Contains(o)) {
                res.Add(o);
            }
        }
        return res.ToArray();
    }
}