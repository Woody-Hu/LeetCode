using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SubsetsII
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            IList<IList<int>> returnValue = new List<IList<int>>();

            var useNums = nums.OrderBy(k => k);

            int length = useNums.Count();

            HashSet<UseList> useSet = new HashSet<UseList>();
            useSet.Add(new UseList());


            for (int i = 0; i < length; i++)
            {
                HashSet<UseList> tempSet = new HashSet<UseList>();
                var tempLst = new UseList() { useNums.ElementAt(i) };
                tempSet.Add(tempLst);

                List<UseList> tempLstLst = new List<UseList>();

                for (int j = i+1; j < length; j++)
                {
                    foreach (var oneValue in tempSet)
                    {
                        tempLst = oneValue.Clone() as UseList;
                        tempLst.Add(useNums.ElementAt(j));
                        tempLstLst.Add(tempLst);
                    }

                    foreach (var oneValue in tempLstLst)
                    {
                        tempSet.Add(oneValue);
                    }
                }

                foreach (var oneValue in tempSet)
                {
                    useSet.Add(oneValue);
                }
            }

            foreach (var oneValue in useSet)
            {
                returnValue.Add(oneValue);
            }

            return returnValue;
        }

        class UseList:List<int>,ICloneable
        {
            public override int GetHashCode()
            {
                return this.ToString().GetHashCode();
            }

            public override bool Equals(object obj)
            {
                return obj.ToString().Equals(this.ToString());
            }

            public override string ToString()
            {
                string baseString = string.Empty;

                foreach (var oneValue in this)
                {
                    baseString = baseString + oneValue.ToString();
                }
                return baseString;
            }

            public object Clone()
            {
                UseList returnValue = new UseList();

                returnValue.AddRange(this);

                return returnValue;
            }
        }
    }
}
