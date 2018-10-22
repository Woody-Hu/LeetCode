using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class LongPressedName
    {
        public bool IsLongPressedName(string name, string typed)
        {
            var typedLength = typed.Length;
            var nameLength = name.Length;
            var nameIndex = 0;

            for (int i = 0; i < typedLength && nameIndex < nameLength; i++)
            {
                if (typed[i] == name[nameIndex])
                {
                    nameIndex++;
                }
                else if (nameIndex > 0 && name[nameIndex -1] == typed[i])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return nameIndex == name.Length;
        }
    }
}
