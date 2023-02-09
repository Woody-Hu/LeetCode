using System;
using System.Collections.Generic;

namespace LeetCode
{
	public class remove_sub_folders_from_the_filesystem
	{
        public IList<string> RemoveSubfolders(string[] folder)
        {
            Array.Sort(folder);
            var ans = new List<string>();
            ans.Add(folder[0]);
            for (int i = 1; i < folder.Length; ++i)
            {
                int pre = ans[ans.Count - 1].Length;
                if (!(pre < folder[i].Length && folder[i].StartsWith(ans[ans.Count - 1] + "/")))
                {
                    ans.Add(folder[i]);
                }
            }

            return ans;
        }
    }
}

