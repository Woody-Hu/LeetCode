using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
	public class accounts_merge
	{
		public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
		{
			var emailToIndex = new Dictionary<string, int>();
			var emailToName = new Dictionary<string, string>();
			var emailIndex = 0;
            foreach (var item in accounts)
            {
				var userName = item[0];
                for (int i = 1; i < item.Count; i++)
                {
                    if (!emailToIndex.ContainsKey(item[i]))
                    {
						emailToIndex.Add(item[i], emailIndex++);
                    }

                    if (!emailToName.ContainsKey(item[i]))
                    {
                        emailToName.Add(item[i], userName);
                    }
                }
            }

            var parents = new int[emailIndex];
            for (int i = 0; i < parents.Length; i++)
            {
                parents[i] = i;
            }

            foreach (var item in accounts)
            {
                var firstEmail = item[1];
                for (int i = 2; i < item.Count; i++)
                {
                    Merge(parents, emailToIndex[firstEmail], emailToIndex[item[i]]);
                }
            }

            var emails = new Dictionary<int, List<string>>();
            foreach (var item in accounts)
            {
                for (int i = 1; i < item.Count; i++)
                {
                    var email = item[i];
                    var index = emailToIndex[email];
                    var parentIndex = Find(parents, index);
                    if (!emails.ContainsKey(parentIndex))
                    {
                        emails.Add(parentIndex, new List<string>());
                    }

                    emails[parentIndex].Add(email);
                }
            }

            var res = new List<IList<string>>();
            foreach (var item in emails)
            {
                var firstEmail = item.Value.First();
                var userName = emailToName[firstEmail];
                var list = new List<string>();
                list.Add(userName);
                var emailList = item.Value.Distinct().OrderBy(k => k).ToList();
                emailList.Sort(StringComparer.Ordinal);
                list.AddRange(emailList);
                res.Add(list);
            }

            return res;
		}

        private int Find(int[] parents, int i)
        {
            if (parents[i] == i)
            {
                return i;
            }
            else
            {
                parents[i] = Find(parents, parents[i]);
                return parents[i];
            }
        }

        private void Merge(int[] parents, int i, int j)
        {
            var left = Math.Min(i, j);
            var right = Math.Max(i, j);

            parents[Find(parents, right)] = parents[Find(parents, left)];
        }
	}
}

