using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class RestoreIPAddresses
    {
        public IList<string> RestoreIpAddresses(string s)
        {
            List<String> res = new List<String>();
            int len = s.Length;
            for (int i = 1; i < 4 && i < len - 2; i++)
            {
                for (int j = i + 1; j < i + 4 && j < len - 1; j++)
                {
                    for (int k = j + 1; k < j + 4 && k < len; k++)
                    {
                        String s1 = s.Substring(0, i ), s2 = s.Substring(i, j   - i), s3 = s.Substring(j, k  - j), s4 = s.Substring(k, len   -k);
                        if (isValid(s1) && isValid(s2) && isValid(s3) && isValid(s4))
                        {
                            res.Add(s1 + "." + s2 + "." + s3 + "." + s4);
                        }
                    }
                }
            }
            return res;
        }

        private bool isValid(string inputString)
        {
            if (inputString.Length > 3 || inputString.Length == 0 || (inputString[0] == '0' && inputString.Length > 1) || int.Parse(inputString)> 255)
                return false;
            return true;
        }
    }
}
