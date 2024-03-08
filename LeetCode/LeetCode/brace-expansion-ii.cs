using System.Collections.Generic;
using System.Linq;

namespace LeetCode;

public class brace_expansion_ii
{
    public IList<string> BraceExpansionII(string expression)
    {
        HashSet<string> res = new HashSet<string>();
        var queue = new Queue<string>();
        queue.Enqueue(expression);
        while (queue.Any())
        {
            var curr = queue.Dequeue();
            var left = -1;
            var right = 0;
            while(right < curr.Length && curr[right] != '}') {
                if (curr[right] == '{') {
                    left = right;
                }
                right++;
            }

            if (left == -1)
            {
                res.Add(curr);
                continue;
            }
            
            var start = curr.Substring(0, left);
            var end = curr.Substring(right + 1);
            var options = curr.Substring(left + 1, right - left - 1).Split(',');
            foreach (var option in options)
            {
                queue.Enqueue(start + option + end);
            }

        }
        
        var list = res.ToList();
        list.Sort();
        return list;
    }
    
}