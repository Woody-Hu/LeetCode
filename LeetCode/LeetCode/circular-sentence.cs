using System;
namespace LeetCode
{
	public class circular_sentence
	{
        public bool IsCircularSentence(string sentence)
        {
            var array = sentence.Split();
            var first = array[0];
            var last = array[array.Length - 1];
            if (first[0] != last[last.Length - 1])
            {
                return false;
            }

            for (int i = 1; i < array.Length; i++)
            {
                var pre = array[i - 1];
                var cur = array[i];
                if (pre[pre.Length - 1] != cur[0])
                {
                    return false;
                }
            }

            return true;
        }
    }
}

