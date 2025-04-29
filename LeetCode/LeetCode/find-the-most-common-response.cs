using System.Collections.Generic;

namespace LeetCode;

public class find_the_most_common_response
{
    public string FindCommonResponse(IList<IList<string>> responses) {
        IDictionary<string, int> counts = new Dictionary<string, int>();
        foreach (IList<string> responsesList in responses) {
            ISet<string> responsesSet = new HashSet<string>();
            foreach (string response in responsesList) {
                if (responsesSet.Add(response)) {
                    counts.TryAdd(response, 0);
                    counts[response]++;
                }
            }
        }
        string common = "";
        int maxCount = 0;
        foreach (KeyValuePair<string, int> pair in counts) {
            string response = pair.Key;
            int count = pair.Value;
            if (count > maxCount || (count == maxCount && response.CompareTo(common) < 0)) {
                common = response;
                maxCount = count;
            }
        }
        return common;
    }
}