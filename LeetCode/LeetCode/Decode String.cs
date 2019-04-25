using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Decode_String
    {
        public string DecodeString(string s)
        {
            string res = "";
            Stack<int> countStack = new Stack<int>();
            Stack<string> resStack = new Stack<string>();
            int idx = 0;
            while (idx < s.Length)
            {
                if (char.IsDigit(s[idx]))
                {
                    int count = 0;
                    while (char.IsDigit(s[idx]))
                    {
                        count = 10 * count + (s[idx] - '0');
                        idx++;
                    }
                    countStack.Push(count);
                }
                else if (s[idx] == '[')
                {
                    resStack.Push(res);
                    res = "";
                    idx++;
                }
                else if (s[idx] == ']')
                {
                    StringBuilder temp = new StringBuilder(resStack.Pop());
                    int repeatTimes = countStack.Pop();
                    for (int i = 0; i < repeatTimes; i++)
                    {
                        temp.Append(res);
                    }
                    res = temp.ToString();
                    idx++;
                }
                else
                {
                    res += s[idx++];
                }
            }
            return res;
        }
    }
}
