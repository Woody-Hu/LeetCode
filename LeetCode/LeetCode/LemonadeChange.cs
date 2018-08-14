using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class LemonadeChange
    {
        public bool LemonadeChangeMethod(int[] bills)
        {
            Dictionary<int, int> useValueCountDic = new Dictionary<int, int>();

            foreach (var oneValue in bills)
            {
                if (oneValue == 5)
                {
                    useValueCountDic[5] = useValueCountDic.GetValueOrDefault(5) + 1;
                }
                else if (oneValue == 10)
                {
                    if (useValueCountDic.GetValueOrDefault(5) > 0)
                    {
                        useValueCountDic[5] = useValueCountDic[5] - 1;
                        useValueCountDic[10] = useValueCountDic.GetValueOrDefault(10) + 1;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (oneValue == 20)
                {
                    if (useValueCountDic.GetValueOrDefault(5) > 0 && useValueCountDic.GetValueOrDefault(10) > 0)
                    {
                        useValueCountDic[5] = useValueCountDic[5] - 1;
                        useValueCountDic[10] = useValueCountDic[10] - 1;
                    }
                    else if (useValueCountDic.GetValueOrDefault(5) > 2)
                    {
                        useValueCountDic[5] = useValueCountDic[5] - 3;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
