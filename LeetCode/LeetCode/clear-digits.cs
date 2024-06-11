using System.Text;

namespace LeetCode;

public class clear_digits
{
    public string ClearDigits(string s) {
        var stringBuilder = new StringBuilder();
        foreach (var c in s)
        {
            if (char.IsDigit(c))
            {
                stringBuilder.Length--;
            }
            else
            {
                stringBuilder.Append(c);
            }
        }
        
        return stringBuilder.ToString();
    }
}