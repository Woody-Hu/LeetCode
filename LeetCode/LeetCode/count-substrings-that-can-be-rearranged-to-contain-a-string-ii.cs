namespace LeetCode;

public class count_substrings_that_can_be_rearranged_to_contain_a_string_ii
{
    public long ValidSubstringCount(string word1, string word2)
    {
        var diff = new int[26];
        foreach (var c in word2)
        {
            diff[c - 'a']--;
        }

        var res = 0l;
        var cnt = 0;
        foreach (var item in diff)
        {
            if (item < 0)
            {
                cnt++;
            }
        }

        var l = 0;
        var r = 0;
        while (l < word1.Length)
        {
            while (r < word1.Length && cnt > 0)
            {
                Update(diff, word1[r] - 'a', 1, ref cnt);
                r++;
            }
            
            if (cnt == 0)
            {
                res += word1.Length - r + 1;
            }
            
            Update(diff, word1[l] - 'a', -1, ref cnt);
            l++;
        }
        
        return res;
    }

    private void Update(int[] diff, int c, int add, ref int cnt)
    {
        diff[c] += add;
        if (add == 1 && diff[c] == 0)
        {
            cnt--;
        }
        else if (add == -1 && diff[c] == -1)
        {
            cnt++;
        }
    }
}