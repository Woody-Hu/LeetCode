using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class UncommonWordsfromTwoSentences
    {
        public string[] UncommonFromSentences(string A, string B)
        {
            var arrayA = A.Split(' ');
            var arrayB = B.Split(' ');

            Dictionary<string, int> dicA = new Dictionary<string, int>();
            Dictionary<string, int> dicB = new Dictionary<string, int>();

            foreach (var oneValue in arrayA)
            {
                dicA[oneValue] = dicA.GetValueOrDefault(oneValue) + 1;
            }

            foreach (var oneValue in arrayB)
            {
                dicB[oneValue] = dicB.GetValueOrDefault(oneValue) + 1;
            }

            HashSet<string> returnValue = new HashSet<string>();

            foreach (var oneKVP in dicA)
            {
                if (oneKVP.Value == 1 && !dicB.ContainsKey(oneKVP.Key))
                {
                    returnValue.Add(oneKVP.Key);
                }
            }

            foreach (var oneKVP in dicB)
            {
                if (oneKVP.Value == 1 && !dicA.ContainsKey(oneKVP.Key))
                {
                    returnValue.Add(oneKVP.Key);
                }
            }

            return returnValue.ToArray();
        }
    }
}
