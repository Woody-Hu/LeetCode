using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MostCommonWord
    {
        public string MostCommonWordMethod(string paragraph, string[] banned)
        {
            paragraph = paragraph.Replace(",", string.Empty).Replace(".", string.Empty).Replace("!", string.Empty).Replace("?", string.Empty).Replace("'", string.Empty).Replace(";", string.Empty);
            var splitedValue = paragraph.Split(' ');

            var groupedValue = splitedValue.GroupBy(k => k.ToLower()).OrderBy(k=>-k.Count());

            HashSet<string> useBannedStr = new HashSet<string>();

            foreach (var oneStr in banned)
            {
                useBannedStr.Add(oneStr);
            }

            foreach (var oneValue in groupedValue)
            {
                if (!useBannedStr.Contains(oneValue.Key))
                {
                    return oneValue.Key;
                }
   
            }

            return string.Empty;
        }
    }
}
