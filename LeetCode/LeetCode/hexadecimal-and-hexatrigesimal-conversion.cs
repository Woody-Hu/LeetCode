using System.Text;

namespace LeetCode;

public class hexadecimal_and_hexatrigesimal_conversion
{
    public string ConcatHex36(int n)
    {
        return ToBase(n * n, 16) + ToBase(n * n * n, 36);
    }

    public string ToBase(int num, int baseValue)
    {
        StringBuilder sb = new StringBuilder();
        while (num != 0)
        {
            int remainder = num % baseValue;
            char digit = remainder < 10 ? (char)('0' + remainder) : (char)('A' + remainder - 10);
            sb.Append(digit);
            num /= baseValue;
        }

        StringBuilder sb2 = new StringBuilder();
        for (int i = sb.Length - 1; i >= 0; i--)
        {
            sb2.Append(sb[i]);
        }

        return sb2.ToString();
    }
}
    