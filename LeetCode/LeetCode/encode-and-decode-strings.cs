using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class encode_and_decode_strings
    {
        // Encodes a list of strings to a single string.
        public string encode(IList<string> strs)
        {
            var stringBuilder = new StringBuilder();
            foreach (var item in strs)
            {
                var length = item.Length;
                var charBytes = new char[4];
                for (int i = 3; i >= 0; i--)
                {
                    charBytes[3 - i] = (char)(length >> (i * 8) & 0xff);
                }

                stringBuilder.Append(charBytes);
                stringBuilder.Append(item);
            }

            return stringBuilder.ToString();
        }

        // Decodes a single string to a list of strings.
        public IList<string> decode(string s)
        {
            var i = 0;
            var length = s.Length;
            var res = new List<string>();
            while (i < length)
            {
                var chars = s.Substring(i, 4);
                i = i + 4;
                var stringLength = 0;
                foreach (var item in chars)
                {
                    stringLength = (stringLength << 8) + (int)item;
                }

                res.Add(s.Substring(i, stringLength));
                i = i + stringLength;
            }

            return res;
        }
    }
}
