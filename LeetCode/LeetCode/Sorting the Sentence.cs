using System;
namespace LeetCode
{
    public class Sorting_the_Sentence
    {
        public string SortSentence(string s)
        {
            var array = s.Split(' ');
            var resArray = new string[array.Length];
            foreach (var item in array)
            {
                var index = item[item.Length - 1] - '0';
                resArray[index - 1] = item.Substring(0, item.Length - 1);
            }

            return string.Join(' ', resArray);
        }
    }
}
