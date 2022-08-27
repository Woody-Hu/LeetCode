using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class decode_the_message
    {
        public string DecodeMessage(string key, string message)
        {
            var dic = new Dictionary<char, char>();
            dic.Add(' ', ' ');
            var index = 'a';
            foreach (var item in key)
            {
                if (!dic.ContainsKey(item))
                {
                    dic.Add(item, index);
                    index++;
                    if (index >= 'z' + 1)
                    {
                        break;
                    }
                }
            }

            var stringBuilder = new StringBuilder();
            foreach (var item in message)
            {
                stringBuilder.Append(dic[item]);
            }

            return stringBuilder.ToString();
        }
    }
}

