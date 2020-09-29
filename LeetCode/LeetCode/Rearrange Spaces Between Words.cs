using System;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class Rearrange_Spaces_Between_Words
    {
        public Rearrange_Spaces_Between_Words()
        {
        }

        public string ReorderSpaces(string text)
        {
            var spaces = text.Count(x => x == ' ');
            var allWords = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var optimalSpacesCount = allWords.Length == 1 ? 0 : spaces / (allWords.Length - 1);
            var optimalSpace = new string(' ', optimalSpacesCount);
            var endSpaceCount = allWords.Length == 1 ? spaces : spaces % (allWords.Length - 1);
            var endSpace = new string(' ', endSpaceCount);
            var sb = new StringBuilder();
            for (int i = 0; i < allWords.Length; i++)
            {
                sb.Append(allWords[i]);
                if (i < allWords.Length - 1)
                    sb.Append(optimalSpace);
                else
                    sb.Append(endSpace);
            }
            return sb.ToString();
        }
    }
}
