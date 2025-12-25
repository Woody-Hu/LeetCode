using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class majority_frequency_characters
    {
        public string MajorityFrequencyGroup(string s)
        {
            IDictionary<char, int> characterToFrequency = new Dictionary<char, int>();
            IDictionary<int, ISet<char>> frequencyToGroup = new Dictionary<int, ISet<char>>();
            foreach (char c in s)
            {
                characterToFrequency.TryAdd(c, 0);
                characterToFrequency[c]++;
            }
            ICollection<char> characters = characterToFrequency.Keys;
            foreach (char c in characters)
            {
                int frequency = characterToFrequency[c];
                frequencyToGroup.TryAdd(frequency, new HashSet<char>());
                frequencyToGroup[frequency].Add(c);
            }
            int majorityFrequency = 0, majoritySize = 0;
            ICollection<int> frequencies = frequencyToGroup.Keys;
            foreach (int frequency in frequencies)
            {
                ISet<char> group = frequencyToGroup[frequency];
                if (group.Count > majoritySize || (group.Count == majoritySize && frequency > majorityFrequency))
                {
                    majorityFrequency = frequency;
                    majoritySize = group.Count;
                }
            }
            StringBuilder sb = new StringBuilder();
            ISet<char> majorityGroup = frequencyToGroup[majorityFrequency];
            foreach (char c in majorityGroup)
            {
                sb.Append(c);
            }
            return sb.ToString();

        }
    }
}
