using System;
namespace LeetCode
{
    public class Check_if_All_Characters_Have_Equal_Number_of_Occurrences
    {
        public bool AreOccurrencesEqual(string s)
        {
            var array = new int[26];
            foreach (var item in s)
            {
                array[item - 'a']++;
            }

            var pre = array[s[0] - 'a'];
            foreach (var item in array)
            {
                if (item != 0 && item != pre)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
