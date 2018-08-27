using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class GroupsofSpecialEquivalentStrings
    {
        public int NumSpecialEquivGroups(string[] A)
        {
            HashSet<string> useSet = new HashSet<string>();

            StringBuilder useOddStringBuilder = new StringBuilder();

            StringBuilder useEvenStringBuilder = new StringBuilder();

            foreach (var oneStr in A)
            {
                useOddStringBuilder.Clear();
                useEvenStringBuilder.Clear();
                for (int i = 0; i < oneStr.Length; i++)
                {
                    if (i%2 != 0)
                    {
                        useOddStringBuilder.Append(oneStr[i]);
                    }
                    else
                    {
                        useEvenStringBuilder.Append(oneStr[i]);
                    }
                }

                var useArray1 = useOddStringBuilder.ToString().ToCharArray();
                var useArray2 = useEvenStringBuilder.ToString().ToCharArray();

                Array.Sort(useArray1);
                Array.Sort(useArray2);

                useSet.Add(new string(useArray1)+","+ new string(useArray2));
            }

            return useSet.Count;

        }
    }
}
