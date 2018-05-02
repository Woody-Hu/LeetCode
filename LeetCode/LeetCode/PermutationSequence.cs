using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class PermutationSequence
    {
        public string GetPermutation(int n, int k)
        {
            int[] useFactorys = new int[n + 1];

            List<int> lstValues = new List<int>();

            useFactorys[0] = 1;

            int useTempValue = 1;

            for (int tempIndex = 1; tempIndex <= n; tempIndex++)
            {
                useTempValue = useTempValue * tempIndex;
                useFactorys[tempIndex] = useTempValue;
                lstValues.Add(tempIndex);
            }

            StringBuilder useStringBuilder = new StringBuilder();
            k--;
            for (int tempIndex = 1; tempIndex <= n; tempIndex++)
            {
                var useIndex = k / useFactorys[n - tempIndex];
                useStringBuilder.Append(lstValues[useIndex]);
                lstValues.RemoveAt(useIndex);

                k = k - useIndex * useFactorys[n - tempIndex];
            }

            return useStringBuilder.ToString();
        }
    }
}
