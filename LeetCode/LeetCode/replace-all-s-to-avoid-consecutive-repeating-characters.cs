using System;
namespace LeetCode
{
    public class replace_all_s_to_avoid_consecutive_repeating_characters
    {
        public string ModifyString(string s)
        {
            var n = s.Length;
            var arr = s.ToCharArray();
            for (int i = 0; i < n; ++i)
            {
                if (arr[i] == '?')
                {
                    for (char ch = 'a'; ch <= 'c'; ++ch)
                    {
                        if ((i > 0 && arr[i - 1] == ch) || (i < n - 1 && arr[i + 1] == ch))
                        {
                            continue;
                        }

                        arr[i] = ch;
                        break;
                    }
                }
            }

            return new string(arr);
        }
    }
}
