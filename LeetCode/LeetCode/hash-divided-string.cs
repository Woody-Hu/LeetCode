namespace LeetCode;

public class hash_divided_string
{
    public string StringHash(string s, int k) {
        var n = s.Length;
        var res = new char[n / k];
        for (var i = 0; i < n; i += k)
        {
            var sum = 0;
            for (var j = i; j < i + k; j++)
            {
                sum += s[ j] - 'a';
            }
            
            res[i / k] = (char)('a' + sum % 26);
        }
        
        return new string(res);
    }
}