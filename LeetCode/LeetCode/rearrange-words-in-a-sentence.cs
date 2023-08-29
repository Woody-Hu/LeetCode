using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
	public class rearrange_words_in_a_sentence
	{
        public string ArrangeWords(string text)
        {
            var array = text.ToLower().Split(" ");
            var list = new List<(int, string)>(array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                list.Add((i, array[i]));
            }

            list.Sort((a, b) =>
            {
                if (a.Item2.Length == b.Item2.Length)
                {
                    return a.Item1 - b.Item1;
                }

                return a.Item2.Length - b.Item2.Length;
            });

            array = list.Select(k => k.Item2).ToArray();
            array[0] = array[0].Substring(0, 1).ToUpper() + array[0].Substring(1);
            return string.Join(" ", array);
        }

    }
}

