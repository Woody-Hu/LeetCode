using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class permutation_i_lcci
	{
        public string[] Permutation(string S)
        {
            var res = new List<string>();
            var tempArray = S.ToCharArray();
            var i = 0;
            Backtrack(i, res, tempArray);
            return res.ToArray();
        }

        private void Backtrack(int i, List<string> res, char[] array)
        {
            if (i == array.Length)
            {
                res.Add(new string(array));
            }

            for (int j = i; j < array.Length; j++)
            {
                Swap(array, i, j);
                Backtrack(i + 1, res, array);
                Swap(array, i, j);
            }
        }

        private void Swap(char[] array, int index1, int index2)
        {
            var temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}

