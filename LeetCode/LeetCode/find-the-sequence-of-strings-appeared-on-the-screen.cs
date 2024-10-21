using System.Collections.Generic;
using System.Text;

namespace LeetCode;

public class find_the_sequence_of_strings_appeared_on_the_screen
{
    public IList<string> StringSequence(string target) {
        var result = new List<string>();
        var s = new StringBuilder();
        foreach (var c in target)
        {
            s.Append("a");
            for (char j = 'a'; j <= c; j++)
            {
                s[^1] = j;
                result.Add(s.ToString());
            }
        }
        
        return result;
    }
}