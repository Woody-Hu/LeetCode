using System;
namespace LeetCode
{
    public class Check_if_One_String_Swap_Can_Make_Strings_Equal
    {
        public bool AreAlmostEqual(string s1, string s2)
        {
            var returnValue = false;
            var diff = 0;
            char s1c = default;
            char s2c = default;

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    diff++;
                    if (diff == 1)
                    {
                        s1c = s1[i];
                        s2c = s2[i];
                    }
                    else if (diff == 2)
                    {
                        if (s1c == s2[i] && s2c == s1[i])
                        {
                            returnValue = true;
                        }
                        else
                        {
                            returnValue = false;
                            break;
                        }
                    }
                    else
                    {
                        returnValue = false;
                        break;
                    }
                }
            }

            if (diff == 0)
            {
                returnValue = true;
            }

            return returnValue;
        }
    }
}
