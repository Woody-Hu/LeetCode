using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class largest_values_from_labels
	{
        public int LargestValsFromLabels(int[] values, int[] labels, int numWanted, int useLimit)
        {
            var maxScore = 0;
            var n = values.Length;
            var valuesLabels = new int[n][];
            for (int i = 0; i < n; i++)
            {
                valuesLabels[i] = new int[2];
                valuesLabels[i][0] = values[i];
                valuesLabels[i][1] = labels[i];
            }

            Array.Sort(valuesLabels, (a, b) => b[0] - a[0]);
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < n && numWanted > 0; i++)
            {
                int value = valuesLabels[i][0], label = valuesLabels[i][1];
                dic.TryAdd(label, 0);
                int count = dic[label];
                if (count < useLimit)
                {
                    maxScore += value;
                    dic[label]++;
                    numWanted--;
                }
            }

            return maxScore;
        }
    }
}

