using System;
namespace LeetCode
{
    public class Capitalize_the_Title
    {

        public string CapitalizeTitle(string title)
        {
            var res = title.ToCharArray();
            for (int i = 0, j = 0; i <= title.Length; ++i)
            {
                if (i == title.Length || title[i] == ' ')
                {
                    if (i - j > 2)
                        res[j] = char.ToUpper(title[j]);
                    j = i + 1;
                }
                else
                    res[i] = char.ToLower(title[i]);
            }

            return new string(res);
        }
    }
}
