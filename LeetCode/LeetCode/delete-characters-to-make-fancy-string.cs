using System.Text;

namespace LeetCode;

public class delete_characters_to_make_fancy_string
{
    public string MakeFancyString(string s)
    {
        var stringBuilder = new StringBuilder();
        foreach (var c in s)
        {
            if (stringBuilder.Length < 2 || stringBuilder[^1] != c || stringBuilder[^2] != c)
            {
                stringBuilder.Append(c);
            }
        }
        
        return stringBuilder.ToString();

    }
}