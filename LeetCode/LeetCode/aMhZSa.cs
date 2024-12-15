using System.Collections.Generic;

namespace LeetCode;

public class aMhZSa
{
    public bool IsPalindrome(ListNode head) {
        var vals = new List<int>();
        while (head != null) {
            vals.Add(head.val);
            head = head.next;
        }
        
        var n = vals.Count;
        for (var i = 0; i < n / 2; i++) {
            if (vals[i] != vals[n - i - 1]) {
                return false;
            }
        }
        
        return true;
    }
}