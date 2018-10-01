using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class XofaKindinaDeckofCards
    {
        public bool HasGroupsSizeX(int[] deck)
        {
            Dictionary<int, int> useDic = new Dictionary<int, int>();

            foreach (var oneValue in deck)
            {
                useDic[oneValue] = useDic.GetValueOrDefault(oneValue)+1;
            }

            var useValue = useDic.Values.ToArray();

            Array.Sort(useValue);

            if (useValue.Length == 1 && useValue[0] == 1)
            {
                return false;
            }

            bool tag = false;

            for (int j = 2; j <= useValue[0]; j++)
            {
                tag = true;

                for (int i = 0; i < useValue.Count(); i++)
                {
                    if (useValue[i] % j != 0)
                    {
                        tag = false;
                    }
                }

                if (tag)
                {
                    return true;
                }
            }

       

            return false;
        }
    }
}
