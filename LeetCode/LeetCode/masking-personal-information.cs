using System;
using System.Text;

namespace LeetCode
{
	public class masking_personal_information
	{
        public string MaskPII(string s)
        {
            string[] country = { "", "+*-", "+**-", "+***-" };
            var atIndex = s.IndexOf("@");
            if (atIndex > 0)
            {
                s = s.ToLower();
                return (s[0] + "*****" + s.Substring(atIndex - 1)).ToLower();
            }

            var sb = new StringBuilder();
            foreach (char c in s)
            {
                if (char.IsDigit(c))
                {
                    sb.Append(c);
                }
            }
            s = sb.ToString();
            return country[s.Length - 10] + "***-***-" + s.Substring(s.Length - 4);
        }
    }
}

