using System;
using System.Text;

namespace LeetCode
{
	public class binary_number_to_string_lcci
	{
        public string PrintBin(double num)
        {
            var stringBuilder = new StringBuilder("0.");
            while (stringBuilder.Length <= 32 && num != 0)
            {
                num *= 2;
                var intPart = (int)num;
                stringBuilder.Append(intPart);
                num -= intPart;
            }

            return stringBuilder.Length <= 32 ? stringBuilder.ToString() : "ERROR";
        }
    }
}

