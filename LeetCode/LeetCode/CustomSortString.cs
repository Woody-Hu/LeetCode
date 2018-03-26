using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class CustomSortString
    {
        public string CustomSortStringMethod(string S, string T)
        {
            Dictionary<char, int> tempDic = new Dictionary<char, int>();
            for (int tempIndex = 0; tempIndex < S.Length; tempIndex++)
            {
                tempDic.Add(S[tempIndex], tempIndex);
            }

            var tempLst = T.ToList();

            SwapList(tempLst, tempDic, 0, tempLst.Count - 1);


            return new string(tempLst.ToArray());
        }

        private void SwapList(List<char> inputChar,Dictionary<char, int> inputDic,int start,int end)
        {
            if (end <= start)
            {
                return;
            }

            int mid = start + (end + 1 - start) / 2;

            for (int j = start; j < mid; j++)
            {
                if (!inputDic.ContainsKey(inputChar[j]))
                {
                    continue;
                }

                for (int i = mid; i <= end; i++)
                {
                    if (!inputDic.ContainsKey(inputChar[i]))
                    {
                        continue;
                    }


                    if (inputDic[inputChar[j]] > inputDic[inputChar[i]])
                    {
                        var temp = inputChar[j];

                        inputChar[j] = inputChar[i];

                        inputChar[i] = temp;
                    }
                }
            }

            SwapList(inputChar, inputDic, start, mid - 1);
            SwapList(inputChar, inputDic, mid, end);
        }
    }
}
