namespace LeetCode;

public class count_substrings_that_satisfy_k_constraint_i
{
    public int CountKConstraintSubstrings(string s, int k) {
        var n = s.Length;
        var res = 0;
        var left = 0;
        var count = new int[2];
        for (var i = 0; i < n; i++)
        {
            count[s[i] & 1]++;
            while (count[0] > k && count[1] > k)
            {
                count[s[left] & 1]--;
                left++;
            }
            
            res += i - left + 1;
        }
        
        return res;
    }
}