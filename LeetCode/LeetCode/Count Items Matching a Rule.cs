using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Count_Items_Matching_a_Rule
    {
        public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            var res = 0;
            var index = 0;
            if (ruleKey[0] == 't')
            {
                index = 0;
            }
            else if (ruleKey[0] == 'c')
            {
                index = 1;
            }
            else
            {
                index = 2;
            }

            foreach (var item in items)
            {
                if (item[index].Equals(ruleValue, StringComparison.OrdinalIgnoreCase))
                {
                    res++;
                }
            }

            return res;
        }
    }
}
