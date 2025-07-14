using System;
using System.Text;

namespace LeetCode;

public class process_string_with_special_operations_i
{
    const char REMOVE = '*', DUPLICATE = '#', REVERSE = '%';

    public string ProcessStr(string s) {
        var result = new StringBuilder();
        foreach (char c in s) {
            if (char.IsLetter(c)) {
                result.Append(c);
            } else if (c == REMOVE) {
                result.Length = Math.Max(result.Length - 1, 0);
            } else if (c == DUPLICATE) {
                result.Append(result);
            } else if (c == REVERSE) {
                char[] arr = result.ToString().ToCharArray();
                Array.Reverse(arr);
                result.Clear();
                result.Append(arr);
            }
        }
        
        return result.ToString();
    }

}