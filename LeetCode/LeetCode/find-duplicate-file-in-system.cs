using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class find_duplicate_file_in_system
    {
        public IList<IList<string>> FindDuplicate(string[] paths)
        {
            var dic = new Dictionary<string, List<string>>();
            foreach (var item in paths)
            {
                var splitedRes = item.Split(' ');
                var path = splitedRes[0];
                for (int i = 1; i < splitedRes.Length; i++)
                {
                    var info = splitedRes[i];
                    var array = info.Split('(');
                    var fileName = array[0];
                    var fileContent = array[1].TrimEnd(')');
                    if (!dic.ContainsKey(fileContent))
                    {
                        dic.Add(fileContent, new List<string>());
                    }

                    var fullName = $"{path}/{fileName}";
                    dic[fileContent].Add(fullName);
                }
            }

            var res = new List<IList<string>>();
            foreach (var item in dic)
            {
                if (item.Value.Count > 1)
                {
                    res.Add(item.Value);
                }
            }

            return res;
        }
    }
}
