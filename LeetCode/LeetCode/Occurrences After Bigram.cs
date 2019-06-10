using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Occurrences_After_Bigram
    {
        public string[] FindOcurrences(string text, string first, string second)
        {
            var array = text.Split(' ');
            var list = new List<string>();
            for (int i = 2; i < array.Length; i++)
            {
                if (array[i - 2] == first && array[i - 1] == second)
                {
                    list.Add(array[i]);
                }
            }

            return list.ToArray();
        }
    }
}
