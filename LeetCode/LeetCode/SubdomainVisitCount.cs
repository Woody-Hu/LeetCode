using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class SubdomainVisitCount
    {
        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            Dictionary<string, int> useDic = new Dictionary<string, int>();

            foreach (var oneStr in cpdomains)
            {
                var tempSplitValue = oneStr.Split(' ');
                var useCount = int.Parse(tempSplitValue[0]);

                var allValue = tempSplitValue[1].Split('.');

                var tempStr = string.Empty;

                for (int i = allValue.Length - 1; i >= 0; i--)
                {
                    tempStr = allValue[i] + (string.IsNullOrWhiteSpace(tempStr)? tempStr : "." + tempStr);

                    useDic[tempStr] = useDic.GetValueOrDefault(tempStr) + useCount;
                }
            }

            List<string> returnValue = new List<string>();

            foreach (var oneKVP in useDic)
            {
                returnValue.Add(oneKVP.Value +" " + oneKVP.Key);
            }

            return returnValue;
        }
    }
}
