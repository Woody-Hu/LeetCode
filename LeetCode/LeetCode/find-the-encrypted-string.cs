namespace LeetCode;

public class find_the_encrypted_string
{
    public string GetEncryptedString(string s, int k) {
        k %= s.Length;
        return s.Substring(k) + s.Substring(0, k);

    }
}