using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class check_array_formation_through_concatenation
    {
        public bool CanFormArray(int[] arr, int[][] pieces)
        {
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < pieces.Length; i++)
            {
                dic[pieces[i][0]] = i;
            }

            for (int i = 0; i < arr.Length;)
            {
                var item = arr[i];
                if (!dic.TryGetValue(item, out var piecesIndex))
                {
                    return false;
                }

                var piece = pieces[piecesIndex];
                for (var j = 0; j < piece.Length; i++, j++)
                {
                    if (arr[i] != piece[j]) return false;
                }
            }

            return true;
        }
    }
}

