using System;
using System.Text;

namespace LeetCode
{
    public class removing_stars_from_a_string
    {
        public string RemoveStars(string s)
        {
            var stringBuilder = new StringBuilder();
            foreach (var item in s)
            {
                if (item != '*')
                {
                    stringBuilder.Append(item);
                }
                else
                {
                    stringBuilder.Remove(stringBuilder.Length - 1, 1);
                }
            }

            return stringBuilder.ToString();
        }
    }
}
