using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class GroupAnagrams
    {
        public GroupAnagrams()
        {
        }

        public IList<IList<string>> GroupAnagramsMethod(string[] strs)
        {
            var groupValue = strs.GroupBy((k) => InnerMethod(k));

            List<IList<string>> returnValue = new List<IList<string>>();

            foreach (var oneValue in groupValue)
            {
                returnValue.Add(oneValue.ToList());
            }

            return returnValue;
        }

        private string InnerMethod(string input)
        {
            var useArray = input.ToCharArray();

            Array.Sort(useArray);

            return new string(useArray);
        }

    }
}
