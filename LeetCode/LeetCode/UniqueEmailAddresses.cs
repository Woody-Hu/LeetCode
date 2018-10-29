using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class UniqueEmailAddresses
    {
        public int NumUniqueEmails(string[] emails)
        {
            HashSet<string> useSet = new HashSet<string>();

            foreach (var oneEmail in emails)
            {
                var tempStrArray = oneEmail.Split('@');

                var tempStr1 = tempStrArray[1];

                var tempStr2 = (tempStrArray[0].Split('+')[0]).Replace(".","");

                useSet.Add(tempStr2 + "@" + tempStr1);
            }

            return useSet.Count;
        }
    }
}
