using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class analyze_user_website_visit_pattern
    {
        public IList<string> MostVisitedPattern(string[] username, int[] timestamp, string[] website)
        {
            var records = new List<VisitRecord>();
            for (int i = 0; i < username.Length; i++)
            {
                records.Add(new VisitRecord() { UserName = username[i], Timestamp = timestamp[i], WebSite = website[i] });
            }

            var ordered = records.OrderBy(k => k.Timestamp);
            var dictUserVisits = new Dictionary<string, List<string>>();
            foreach (var item in ordered)
            {
                if (!dictUserVisits.ContainsKey(item.UserName))
                {
                    dictUserVisits.Add(item.UserName, new List<string>());
                }

                dictUserVisits[item.UserName].Add(item.WebSite);
            }

            var patternScores = new Dictionary<List<string>, int>();
            var orderedVisites = dictUserVisits.OrderBy(k => k.Value.Count());
            foreach (var item in orderedVisites)
            {
                var allPatterns = GetAllPatterns(item.Value);
                foreach (var reslovePattern in allPatterns)
                {
                    if (!patternScores.Any())
                    {
                        patternScores.Add(reslovePattern, 1);
                        continue;
                    }

                    List<List<string>> matches = new List<List<string>>();
                    foreach (var onePattern in patternScores)
                    {
                        if (IfMatch(onePattern.Key, reslovePattern))
                        {
                            matches.Add(onePattern.Key);
                        }
                    }

                    if (!matches.Any())
                    {
                        patternScores.Add(reslovePattern, 1);
                        continue;
                    }

                    foreach (var match in matches)
                    {
                        patternScores[match]++;
                    }
                }
               
            }

            var orderedByScores = patternScores.OrderByDescending(k => k.Value).ThenBy(k => ToString(k.Key));
            return orderedByScores.First().Key;
        }

        private bool IfMatch(List<string> shorter, List<string> input)
        {
            var i = 0;
            var j = 0;
            while (i < shorter.Count() && j < input.Count())
            {
                if (shorter[i].Equals(input[j]))
                {
                    i++;
                    j++;
                }
                else
                {
                    j++;
                }
            }

            return i == shorter.Count() && j == input.Count();
        }

        private string ToString(List<string> input)
        {
            var tag = $"{input[0]}#{input[1]}#{input[2]}";

            return tag;
        }

        private List<List<string>> GetAllPatterns(List<string> input)
        {
            if (input.Count() == 3)
            {
                return new List<List<string>>() { input};
            }

            if (input.Count() < 3)
            {
                return new List<List<string>>() { };
            }

            var res = new List<List<string>>() { };
            var added = new HashSet<string>();
            for (int i = 0; i < input.Count; i++)
            {
                for (int j = i + 1; j < input.Count; j++)
                {
                    for (int k = j+ 1; k < input.Count; k++)
                    {
                        var tag = $"{input[i]}#{input[j]}#{input[k]}";
                        if (!added.Contains(tag))
                        {
                            res.Add(new List<string>() { input[i], input[j], input[k] });
                        }

                        added.Add(tag);
                    }
                }
            }

            return res;
        }

        private class VisitRecord
        {
            internal string UserName { get; set; }

            internal int Timestamp { get; set; }

            internal string WebSite { get; set; }
        }
    }
}
