using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class _3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> returnValue = new List<IList<int>>();

            var tempGroup = nums.GroupBy(k => k).ToDictionary(k => k.Key, k => k.Count());

            var keys = tempGroup.Keys.ToArray();

            Array.Sort(keys);

            HashSet<InnerPacker> tempLst = new HashSet<InnerPacker>();

            for (int i = 0; i < keys.Length; i++)
            {
                var j = i;
                var k = keys.Length;
                tempGroup[keys[i]]--;
                while (j<k)
                {
                    var tempTag = 0 - keys[i] - keys[j];
                    tempGroup[keys[j]]--;

                    if (tempGroup.ContainsKey(tempTag) && tempGroup[keys[j]]>=0 && tempGroup[tempTag]>0 )
                    {
                        int[] tempArray = new int[] { tempTag, keys[i], keys[j] };
                        Array.Sort(tempArray);
                        tempLst.Add(new InnerPacker() { ValueOne = tempArray[0], ValueTwo = tempArray[1], ValueThree = tempArray[2] });
                    }
                    tempGroup[keys[j]]++;
                    j++;
                }
                tempGroup[keys[i]]++;
            }

            foreach (var onePacker in tempLst)
            {
                returnValue.Add(new List<int>() { onePacker.ValueOne, onePacker.ValueTwo, onePacker.ValueThree });
            }

            return returnValue;
        }


        private class InnerPacker
        {
            internal int ValueOne { set; get; }

            internal int ValueTwo { set; get; }

            internal int ValueThree { set; get; }

            public override string ToString()
            {
                return ValueOne+","+ValueTwo +","+ ValueThree;
            }

            public override int GetHashCode()
            {
                return this.ToString().GetHashCode();
            }

            public override bool Equals(object obj)
            {
                return this.ToString().Equals(obj.ToString());
            }
        }

    }
}
