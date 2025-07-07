using System.Collections.Generic;

namespace LeetCode;

public class partition_string
{
    public IList<string> PartitionString(string s) {
        var res = new List<string>();
        var set = new HashSet<string>();
        var t = "";
        foreach (var c in s)
        {
            t += c;
            if (set.Add(t))
            {
                res.Add(t);
                t = "";
            }
        }

        return res;


    }
}