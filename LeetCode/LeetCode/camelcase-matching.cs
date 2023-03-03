using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class camelcase_matching
	{
        public IList<bool> CamelMatch(string[] queries, string pattern)
        {
            var res = new List<bool>();
            var pArray = pattern.ToCharArray();
            var length = pArray.Length;
            foreach (var queryItem in queries)
            {
                var i = 0;
                var current = true;
                foreach (var item in queryItem)
                {
                    if (i < length && item == pArray[i])
                    {
                        i++;
                    }
                    else if (item >= 'A' && item <= 'Z')
                    {
                        current = false;
                        break;
                    }
                }

                res.Add(current ? i == length : current);
            }

            return res;
        }
    }
}

